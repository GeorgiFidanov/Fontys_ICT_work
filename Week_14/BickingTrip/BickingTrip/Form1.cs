using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BickingTrip
{
    public partial class Form1 : Form
    {
        private List<Trip> trips;
        public TripManager tripManager;

        public Form1()
        {
            InitializeComponent();
            Trip amsterdam = new Trip("Amsterdam", 121, 4);
            Trip rome = new Trip("Rome", 1532, 4);
            Trip paris = new Trip("Paris", 447, 4.5);
            Trip london = new Trip("London", 187, 2.7);
            this.trips = new List<Trip> { amsterdam, rome, paris, london };
            this.tripManager = new TripManager(trips);
            btnShowAll_Click(this, EventArgs.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string destination = tbxTo.Text;
            double distance = Convert.ToDouble(nudDistance.Value); 
            double rating = Convert.ToDouble(nudRating.Value);

            if (!String.IsNullOrEmpty(destination) && distance > 0)
            {
                tripManager.AddTrip(destination, distance, rating);
                lbxMyTrips.Items.Add(destination);
                tbxTo.Clear();
                nudDistance.Value = 0m;
                nudRating.Value = 0m;
            }

            else
            {
                MessageBox.Show("Please supply a valid destination and/or distance");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbxMyTrips.Items.Clear();
            this.trips = tripManager.GetTrips();
            foreach (Trip trip in trips)
            {
                lbxMyTrips.Items.Add(trip.GetDestination());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxMyTrips.SelectedIndex > -1)
            {
                int selectedIndex = lbxMyTrips.SelectedIndex;
                string selectedDestination = lbxMyTrips.Items[selectedIndex].ToString();
                this.trips = tripManager.GetTrips();
                int originalIndex = trips.FindIndex(trip => trip.GetDestination() == selectedDestination);
                //^Handles an edge case:
                //When an user tries to delete through filtered trips (on display)
                //-ensures to find the original index and not to just pop the first element

                if (originalIndex > -1)
                {
                    tripManager.DeleteTrip(originalIndex);
                    lbxMyTrips.SelectedIndex = -1;
                    btnShowAll_Click(sender, e);
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lbxMyTrips.SelectedIndex > -1)
            {
                int index = lbxMyTrips.SelectedIndex;
                if (index > -1)
                {
                    MessageBox.Show(tripManager.GetTripInfo(index));
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            lbxMyTrips.Items.Clear();

            string query = tbxSearch.Text;
            this.trips = tripManager.GetTrips();

            foreach (Trip trip in this.trips)
            {
                if (trip.GetDestination() == query)
                {
                    lbxMyTrips.Items.Add(trip.GetDestination());
                }
            }
        }
    }
}
