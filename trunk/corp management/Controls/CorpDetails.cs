﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eZet.EveLib.Modules.Models;
using eZet.EveLib.Modules;
using eZet.EveLib.Modules.Models.Character;

namespace corp_management.Helper
{
    public partial class CorpDetails : UserControl
    {

        public CorpDetails()
        {
            InitializeComponent();
        }

        public CorpDetails(eZet.EveLib.Modules.Corporation corp)
        {
            InitializeComponent();
            FillCorpDetails(corp);
        }

        private void FillCorpDetails(eZet.EveLib.Modules.Corporation corp)
        {
            // TODO: Complete member initialization
            this.Name = "CorpDetails"; // Name of the control -> mandatory

            this.text_corp_name.Text = corp.CorporationName;
            this.text_alliance_name.Text = corp.AllianceName;

            // TODO: Retrieve Journal Tax data
            EveApiResponse<WalletJournal> wallet = corp.GetWalletJournal(1000, 500, 0);
            DateTime startDate = new DateTime(2014,7,1);
            /*foreach (EveOnlineRowCollection<WalletJournal.JournalEntry> jEntry in (WalletJournal.JournalEntry)wallet.Result.Journal.Select(x => x.RefTypeId == 85).ToList())
            {

            }*/

        }
    }
}