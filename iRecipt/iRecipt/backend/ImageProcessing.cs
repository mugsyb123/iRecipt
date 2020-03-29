using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace iRecipt.backend
{
    static class ImageProcessing
    {
        private static List<Member> members;
        private static byte[] image;
        public static void setMemberList(List<Member> membersTemp)
        {
            members = membersTemp;
        } 
    
        public static List<Member> getMembers()
        {
            return members;
        }

        public static void setImage(byte[] tempImage)
        {
            image = tempImage;
        }

        public static byte[] getImage()
        {
            return image;
        }
    }
}
