using iRecipt.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iRecipt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddMembersPage : ContentPage
    {
        private String placeholder = "Enter a name";
        public AddMembersPage()
        {
            InitializeComponent();
            
            //Create our first entry box
            addEntry();

            //Set up for future boxes
            AddEntry.Clicked += (s, e) => addEntry();

            // Navigates to the next page, which is the split page
            //SplitBill.IsEnabled = false; //enable this once there is a value other than default
            SplitBill.Clicked += (s, e) => splitBill();

        }
        
        public void splitBill()
        {
            //Create the member list to mess with later
            List<Member> members = new List<Member>();

            //Creates a list of entry members
            var entryMembers = MemberStack.Children.ToList();

            //Add the new member to the list of members
            foreach (Entry member in entryMembers)
                members.Add(new Member(member.Text));

            //Save the list of members
            ImageProcessing.setMemberList(members);

            //Move to new page
            Navigation.PushAsync(new SplitBillPage());
        }

        public void addEntry()
        {
            //Create a new entry for the UI stack
            Entry tempEntry = new Entry { Placeholder = placeholder, 
                HorizontalOptions = LayoutOptions.FillAndExpand, 
                WidthRequest = DeviceDisplay.MainDisplayInfo.Width * .65};

            //Add the element to the stack
            MemberStack.Children.Add(tempEntry);
        }

    }
}