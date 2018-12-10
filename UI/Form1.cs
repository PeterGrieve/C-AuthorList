using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;
using configFile;
using Repository;
using PubsService;

namespace UI
{
    public partial class Form1 : Form
    {


     public class ListViewItemComparer : IComparer
        {
          

            private int col = 0;
            private int sortResult = 0;
            bool Ascending;

            public ListViewItemComparer(int column, bool asc)
            {
     
                col = column;
                Ascending = asc;
            }
            public int Compare(object Item1, object Item2)
            {
                ListViewItem lvItem1 = Item1 as ListViewItem;
                ListViewItem lvItem2 = Item2 as ListViewItem;

                switch (Ascending)
                {
                    
                    case true:
                        { 
                            // Do a descending case insensitive string sort
                            sortResult = -String.Compare(lvItem1.SubItems[col].Text, lvItem2.SubItems[col].Text, true);
                            break;

                        } 
                    case false:
                        {
                            // Do an ascending case insensitive string sort
                            sortResult = String.Compare(lvItem1.SubItems[col].Text, lvItem2.SubItems[col].Text, true);
                            break;
                        }
                        
                    default:
                        sortResult = 0;     // If invalid column passed in
                        break;
                }

                return sortResult;
            }


        }

        Form1 f1;
        Form2 form2;
        Form3 form3;

        public bool[] isAscending = new bool[9];

       public ColumnHeader idHeader;
       public ColumnHeader lnameHeader;
       public ColumnHeader fnameHeader;
       public ColumnHeader phoneHeader;
       public ColumnHeader addressHeader;
       public ColumnHeader cityHeader;
       public ColumnHeader stateHeader;
       public ColumnHeader zipHeader;
       public ColumnHeader contractHeader;


        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form3 = new Form3(this);
            f1 = (this);

            isAscending[0] = true;
            isAscending[1] = true;
            isAscending[2] = true;
            isAscending[3] = true;
            isAscending[4] = true;
            isAscending[5] = true;
            isAscending[6] = true;
            isAscending[7] = true;
            isAscending[8] = true;


            authorListView.Activation = ItemActivation.OneClick;
            authorListView.View = View.Details;
            authorListView.GridLines = true;
            authorListView.FullRowSelect = true;
            authorListView.MultiSelect = false;   

           idHeader = authorListView.Columns.Add("ID");
           lnameHeader = authorListView.Columns.Add("Last Name");
           fnameHeader = authorListView.Columns.Add("First Name");
           phoneHeader = authorListView.Columns.Add("Phone");
           addressHeader = authorListView.Columns.Add("Address");
           cityHeader = authorListView.Columns.Add("City");
           stateHeader = authorListView.Columns.Add("State");
           zipHeader = authorListView.Columns.Add("Zip Code");
           contractHeader = authorListView.Columns.Add("Contract");

            

            authorListView.Columns[0].Width = -2;
            authorListView.Columns[1].Width = -2;
            authorListView.Columns[2].Width = -2;
            authorListView.Columns[3].Width = -2;
            authorListView.Columns[4].Width = -2;
            authorListView.Columns[5].Width = -2;
            authorListView.Columns[7].Width = -2;
            authorListView.Columns[8].Width = -2;

            authorListView.ColumnClick += new ColumnClickEventHandler(ColumnClick);
            authorListView.ItemActivate += new EventHandler(ItemClick);
           
            authorRepository auRepo = new authorRepository();

            authorsService auService = new authorsService(auRepo);

            List<authorViewModel> authors = auService.getAll();

            foreach (authorViewModel au in authors)
            {
                ListViewItem lvi;

                lvi = new ListViewItem(au.ID);

                lvi.SubItems.Add(au.FirstName);
                lvi.SubItems.Add(au.LastName);
                lvi.SubItems.Add(au.Phone);
                lvi.SubItems.Add(au.Address);
                lvi.SubItems.Add(au.City);
                lvi.SubItems.Add(au.State);
                lvi.SubItems.Add(au.Zip);
                lvi.SubItems.Add(au.Contract);
                authorListView.Items.Add(lvi);

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            return;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      private void ColumnClick(object sender, ColumnClickEventArgs e)
      {
           

            ListViewItemComparer sorter = new ListViewItemComparer(e.Column, isAscending[e.Column]);


                        this.authorListView.ListViewItemSorter = sorter as ListViewItemComparer;
 

                isAscending[e.Column] = !(isAscending[e.Column]);

            return;
      }

        private void ItemClick(object sender, EventArgs e)
        {

            form3.ID = this.authorListView.SelectedItems[0].SubItems[0].Text;
            form3.LastName = this.authorListView.SelectedItems[0].SubItems[1].Text;
            form3.FirstName = this.authorListView.SelectedItems[0].SubItems[2].Text;
            form3.Phone = this.authorListView.SelectedItems[0].SubItems[3].Text;
            form3.Address = this.authorListView.SelectedItems[0].SubItems[4].Text;
            form3.City = this.authorListView.SelectedItems[0].SubItems[5].Text;
            form3.State = this.authorListView.SelectedItems[0].SubItems[6].Text;
            form3.ZipCode = this.authorListView.SelectedItems[0].SubItems[7].Text;
            form3.Contract = this.authorListView.SelectedItems[0].SubItems[8].Text;

            form3.ShowDialog();

            this.authorListView.SelectedItems[0].SubItems[0].Text = form3.ID;
            this.authorListView.SelectedItems[0].SubItems[1].Text = form3.LastName;
            this.authorListView.SelectedItems[0].SubItems[2].Text = form3.FirstName;
            this.authorListView.SelectedItems[0].SubItems[3].Text = form3.Phone;
            this.authorListView.SelectedItems[0].SubItems[4].Text = form3.Address;
            this.authorListView.SelectedItems[0].SubItems[5].Text = form3.City;
            this.authorListView.SelectedItems[0].SubItems[6].Text = form3.State;
            this.authorListView.SelectedItems[0].SubItems[7].Text = form3.ZipCode;
            this.authorListView.SelectedItems[0].SubItems[8].Text = form3.Contract;



            return;
        }


   }
}
