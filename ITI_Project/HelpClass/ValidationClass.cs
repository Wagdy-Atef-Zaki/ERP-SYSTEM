using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace ItI_Project
{
    class ValidationClass
    {
        /// String not Empty
       static public  bool StringNotEmpty( String Text)
        {
            if (!String.IsNullOrEmpty(Text) || !String.IsNullOrWhiteSpace(Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       /// String is digit 
       static public bool ISDigit(String Text)
       {
           if (!String.IsNullOrEmpty(Text) || !String.IsNullOrWhiteSpace(Text))
           {
               String str = "[0-9]";
               if (Regex.IsMatch(Text, str))
               {
                   return true;
               }
               else
               {
                   return false;
               }

           }
           else
           { return false; }
       }

      /// String is mobile
       static public bool ISMobile(String Text)
       {
           if (!String.IsNullOrEmpty(Text) || !String.IsNullOrWhiteSpace(Text))
           {
               String str = "[0-9]";
               if (Text.Length == 11)
               {
                   if (Regex.IsMatch(Text, str))
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               }
               else
               {
                   return false;
               }

           }
           else
           { return false; }
       }
       /// lable visable if text is emputy 
       static public void showStar( Label _Lable,bool action )
       {
           if (action == true)
           {
               _Lable.Visible = false;
           }
           else
           {
               _Lable.Visible = true;
           }
       }

    }
}
