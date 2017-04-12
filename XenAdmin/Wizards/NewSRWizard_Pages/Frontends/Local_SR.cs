/* Copyright (c) Citrix Systems, Inc. 
 * All rights reserved. 
 * 
 * Redistribution and use in source and binary forms, 
 * with or without modification, are permitted provided 
 * that the following conditions are met: 
 * 
 * *   Redistributions of source code must retain the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer. 
 * *   Redistributions in binary form must reproduce the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer in the documentation and/or other 
 *     materials provided with the distribution. 
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
 * CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XenAdmin.Actions;
using XenAdmin.Controls;
using XenAdmin.Core;
using XenAdmin.Dialogs;
using XenAdmin.Dialogs.WarningDialogs;
using XenAdmin.Network;
using XenAPI;
using System.Drawing;


namespace XenAdmin.Wizards.NewSRWizard_Pages.Frontends
{
    public partial class Local_SR : XenTabPage
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
               
        private List<FibreChannelDevice> _selectedDevices = new List<FibreChannelDevice>();

        public Local_SR()
        {
            InitializeComponent();
        }

        public virtual SR.SRTypes SrType { get { return SR.SRTypes.dummy; } }//TODO: sr_type is the selected radiobutton

        
        #region XenTabPage overrides

        public override string PageTitle { get { return Messages.NEWSR_SELECT_DEVICE; } }

        public override string Text { get { return Messages.NEWSR_LOCATION; } }

        public override string HelpID { get { return "Location_HBA"; } }

        public override void PageLeave(PageLoadedDirection direction, ref bool cancel)
        {
            if (direction == PageLoadedDirection.Back)
                return;

            Host master = Helpers.GetMaster(Connection);
            if (master == null)
            {
                cancel = true;
                return;
            }            
            base.PageLeave(direction, ref cancel);
        }

        public override bool EnableNext()
        {
            UpdateSelectionButtons();
            return _selectedDevices.Count > 0;
        }

        public override bool EnablePrevious()
        {
            return true;
        }

        public override void PopulatePage()
        {
            dataGridView.Rows.Clear();
        }

        public override string NextText(bool isLastPage)
        {
            // for Dundee or greater connections, we have "Storage provisioning settings" page after this page, so the Next button should say "Next", not "Create"
            return Helpers.DundeeOrGreater(Connection) ?  Messages.WIZARD_BUTTON_NEXT : Messages.NEWSR_LVMOHBA_NEXT_TEXT;
        }

        public override void SelectDefaultControl()
        {
            dataGridView.Select();
        }

        #endregion

        #region Event handlers

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_srWizardType.SrToReattach != null)
                return;

            if (e.ColumnIndex != colCheck.Index || e.RowIndex < 0 || e.RowIndex > dataGridView.RowCount - 1)
                return;
            OnPageUpdated();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_srWizardType.SrToReattach == null)
                return;
            OnPageUpdated();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var row in dataGridView.Rows)
            {
       
            }
            OnPageUpdated();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            foreach (var row in dataGridView.Rows)
            {
               
            }

            OnPageUpdated();
        }

        #endregion

        private void UpdateSelectionButtons()
        {
  
        }

        public bool LocalSRScan(IWin32Window owner, IXenConnection connection)
        {
            //TODO: Implement local device sr_scan functionality
            return true;
        }

        #region Accessors

        public List<FibreChannelDevice> FCDevices { private get; set; }

        private SrWizardType _srWizardType;
        public SrWizardType SrWizardType
        {
            private get
            {
                return _srWizardType;
            }
            set
            {
                _srWizardType = value;

                bool creatingNew = _srWizardType.SrToReattach == null;
                
                colCheck.Visible = creatingNew;
                dataGridView.MultiSelect = creatingNew;
                buttonSelectAll2.Visible = creatingNew;
                buttonClearAll2.Visible = creatingNew;
                labelCreate.Visible = creatingNew;
            }
        }

        /// <summary>
        /// min size
        /// </summary>
        public long SRSize
        {
            get
            {
                long size = long.MaxValue;
                return size;
            }
        }

        #endregion
    }
}
