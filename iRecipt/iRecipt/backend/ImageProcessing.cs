using System;
using System.Collections.Generic;
using System.Text;

namespace iRecipt.backend
{
    static class ImageProcessing
    {
        private static List<Member> members;

        public static void setMemberList(List<Member> membersTemp)
        {
            members = membersTemp;
        } 
    
        public static List<Member> getMembers()
        {
            return members;
        }
    }
}
