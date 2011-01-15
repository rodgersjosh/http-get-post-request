/*
   Copyright (C) 2011 Tom Thorpe

   This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version.

   This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details. You should have received a copy of the GNU General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Collections;



namespace HTTPRequest
{
    /// <remarks>
    /// Extends Form to create an application that allows you to send HTTP GET and POST requests
    /// </remarks>
    public partial class MainForm : Form
    {
        AutoCompleteStringCollection history;
        
        /// <summary>
        /// Constructs the class that shows a GUI for sending HTTP Requests
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //If you don't have a history list saved, create one - otherwise retrieve the saved one
            if (Properties.Settings.Default.History == null)
            {
                history = new AutoCompleteStringCollection();
                Properties.Settings.Default.History = history;
            }
            else
            {
                history = Properties.Settings.Default.History;
            }

            //set the URL's autocomplete to the history list.
            urlTextBox.AutoCompleteCustomSource = history;
        }

        /// <summary>
        /// Sends the request using the data entered on the Form, and updates the responseBox text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goButton_Click(object sender, EventArgs e)
        {
            //declare the Request, Response and url
            HttpWebRequest webRequest;
            WebResponse webResponse = null; //build this outside the scope of the try block
            string url = urlTextBox.Text;

            try
            {
                //construct the web request from the URL
                webRequest = (HttpWebRequest)WebRequest.Create(url);

                //decide whether it's a GET or POST request
                if (getRadio.Checked)
                {
                    webRequest.Method = "GET";
                }
                else
                {
                    webRequest.Method = "POST";
                }

                //if it's a POST request, we also need to add the POST query data
                if (postRadio.Checked)
                {
                    webRequest.ContentType = "application/x-www-form-urlencoded";
                    webRequest.ContentLength = querystringtextbox.Text.Length;

                    StreamWriter stOut = new StreamWriter(webRequest.GetRequestStream(), System.Text.Encoding.ASCII);
                    stOut.Write(querystringtextbox.Text);
                    stOut.Close();
                }

                //send the request and add the url to the history
                webRequest.KeepAlive = false;
                webResponse = webRequest.GetResponse(); //Assign to webResponse
                history.Add(url);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                responseBox.Text = ex.Message + "\nURL:" + url; //put the error message in the response text box
            }
            finally
            {
                if (webResponse != null) //if you got as far as retrieving a web response that wasn't null, display it in the response text
                {
                    StreamReader sr = new StreamReader(webResponse.GetResponseStream());
                    string strRead = sr.ReadToEnd();

                    if (jsonCheckbox.Checked) //if the Json checkbox was checked, format it as JSON using the JsonFormatter by 
                    {
                        JsonFormatter formatter = new JsonFormatter();
                        responseBox.Text = formatter.PrettyPrint(strRead);
                    }
                    else //otherwise if the json checkbox isn't checked, just put the plaintext into the response box
                    {
                        responseBox.Text = strRead;
                    }

                    webResponse.Close(); //Close webresponse connection
                }
                webResponse = null;
                webRequest = null;
            }
        }

        /// <summary>
        /// Event called when the RadioButtons are changed. If the GET radio button is selected, the query string text box is disabled as the query should be appended to the end of the URL in GET.
        /// If the POST radio button is selected the query string text box is enabled as the query string isn't appended to the end of the url.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtons_Changed(object sender, EventArgs e)
        {
            if (getRadio.Checked)
            {
                querystringtextbox.Enabled = false;
            }
            else
            {
                querystringtextbox.Enabled = true;
            }
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Shows the About screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox about = new AboutBox())
            {
                about.ShowDialog();
            }
        }

        /// <summary>
        /// Allows the user to press the Enter button while in the URL text box to send the request instead of having to press the GO button using the mouse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void urlTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                goButton_Click(sender, e);
            }
        }

        /// <summary>
        /// Clears the URL history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history.Clear();
            Properties.Settings.Default.Save();
        }
    }
}
