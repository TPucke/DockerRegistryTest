using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Docker.Registry.DotNet;
using Docker.Registry.DotNet.Authentication;
using Docker.Registry.DotNet.Endpoints;
using Docker.Registry.DotNet.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerRegistryTest
{
    public partial class Form1 : Form
    {
        IRegistryClient _registryClient = default;
        public Form1()
        {
            InitializeComponent();

            comboEndpoint.SelectedIndex = 0;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor PreviousCursor = this.Cursor;
            Cursor = Cursors.WaitCursor;

            if ((sender as Button).Text == "Logout")
            {
                Text = $"Not connected";
                foreach (var control in grpControls.Controls)
                {
                    if (control.GetType() == typeof(ListBox))
                    {
                        ((ListBox)control).Items.Clear();
                    }

                    if (control.GetType() == typeof(TextBox))
                    {
                        ((TextBox)control).Text = "";
                    }

                    // ...
                }

                grpControls.Enabled = false;

                _registryClient = null;
                btnLogin.Text = "Login";
                comboEndpoint.Focus();
            }
            else
            {
                var configuration = new RegistryClientConfiguration(comboEndpoint.SelectedItem?.ToString() ?? comboEndpoint.Text);

                AuthenticationProvider authenticationProvider;

                if (chkAnonymous.Checked)
                {
                    authenticationProvider = new AnonymousOAuthAuthenticationProvider();
                }
                else
                {
                    authenticationProvider = new PasswordOAuthAuthenticationProvider(txtUserName.Text, txtPassword.Text);
                }

                var client = configuration.CreateClient(authenticationProvider);

                try
                {
                    await client.System.PingAsync();
                }
                catch (UnauthorizedAccessException ex)
                {
                    // authentication failed
                    MessageBox.Show("Authentication failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor = PreviousCursor;
                    return;
                }
                catch (RegistryConnectionException ex)
                {
                    // connection failed
                    MessageBox.Show("Unable to connect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor = PreviousCursor;
                    return;
                }

                Text = $"Connected to endpoint {comboEndpoint.SelectedItem.ToString()}";
                grpControls.Enabled = true;
                btnLogin.Text = "Logout";
                _registryClient = client;
                btnCatalog.Focus();
            }

            Cursor = PreviousCursor;
        }

        private void chkAnonymous_CheckedChanged(object sender, EventArgs e)
        {
            var Sender = sender as CheckBox;

            if (Sender.Checked)
            {
                txtUserName.Enabled = txtPassword.Enabled = false;
            }
            else
            {
                txtUserName.Enabled = txtPassword.Enabled = true;
            }
        }

        private async void btnCatalog_Click(object sender, EventArgs e)
        {
            lstRepositories.Items.Clear();

            try
            {
                var catalog = await _registryClient.Catalog.GetCatalogAsync(new CatalogParameters { });
                foreach (string repository in catalog.Repositories)
                {
                    lstRepositories.Items.Add(repository);
                }
                //MessageBox.Show(string.Join(Environment.NewLine, catalog.Repositories), "Catalog of repositories");
            }
            catch (RegistryApiException ex)
            {
                MessageBox.Show($"Exception from GetCatalogAsync: {ex.Message}");
            }
            catch (Exception) { }
        }

        private async void lstRepositories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTags.Items.Clear();
            gridConfig.Rows.Clear();
            gridLayers.Rows.Clear();

            if (lstRepositories.SelectedIndex == -1)
            {
                return;
            }

            var tags = await _registryClient.Tags.ListImageTagsAsync(lstRepositories.SelectedItem.ToString(), new ListImageTagsParameters());

            lstTags.Items.AddRange(tags?.Tags ?? new object[0]);
        }

        private async void lstTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridConfig.Rows.Clear();
            gridLayers.Rows.Clear();

            if (lstTags.SelectedIndex == -1)
            {
                return;
            }

            var result = await _registryClient.Manifest.GetManifestAsync(lstRepositories.SelectedItem.ToString(), lstTags.SelectedItem.ToString());
            var manifest = result.Manifest as ImageManifest2_2;

            gridConfig.Rows.Add(manifest.Config.MediaType, manifest.Config.Size, manifest.Config.Digest);
            
            foreach (var layer in manifest.Layers)
            {
                int newRowIndex = gridLayers.Rows.Add(layer.MediaType, layer.Size, layer.Digest);
                gridLayers.Rows[newRowIndex].HeaderCell.Value = (newRowIndex+1).ToString();
            }
        }

        private async void deleteTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string repository = lstRepositories.SelectedItem.ToString();
            string tag = lstTags.SelectedItem.ToString();

            //We need to get the digest of the manifest
            var manifest = await _registryClient.Manifest.GetManifestAsync(repository, tag);
            string digest = manifest.DockerContentDigest;

            if (string.IsNullOrWhiteSpace(digest))
            {
                MessageBox.Show("Unable to find digest.");
            }
            else
            {
                await _registryClient.Manifest.DeleteManifestAsync(repository, digest);
            }
        }

        private void comboEndpoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }
    }
}
