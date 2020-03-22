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
        private List<Member> members;
        private String placeholder = "Enter a name";
        public AddMembersPage()
        {
            InitializeComponent();

            //Create the list that will be passed in the future
            members = new List<Member>();
            
            //Create our first entry box
            addEntry();

            //Set up for future boxes
            AddEntry.Clicked += (s, e) => addEntry();

            // Navigates to the next page, which is the split page
            //SplitBill.IsEnabled = false; //enable this once there is a value other than default
            SplitBill.Clicked += (s, e) => Navigation.PushAsync(new SplitBillPage());

        }
        
        public void addEntry()
        {
            //Created a new member for our list
            Member newMember = new Member("");

            //Create a new entry for the UI stack
            Entry tempEntry = new Entry { Placeholder = placeholder, HorizontalOptions = LayoutOptions.FillAndExpand, WidthRequest = DeviceDisplay.MainDisplayInfo.Width * .75};

            //Bind the UI stack entry to the new member that we created above
            tempEntry.BindingContext = newMember;
            tempEntry.SetBinding(Entry.TextProperty, new Binding("name"));

            //Add the element to the stack
            MemberStack.Children.Add(tempEntry);

            //Add the new member to the list of members
            members.Add(newMember);
        }

    }
}