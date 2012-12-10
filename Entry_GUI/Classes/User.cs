using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Main_XNA_Game
{
    public class User
    {
        [XmlAttribute("UserName")]
        public String UserName = "";

        [XmlAttribute("Email")]
        public String Email = "";

        [XmlAttribute("Password")]
        public String Password = "";

        [XmlAttribute("TotalScore")]
        public int TotalScore = 0;

        [XmlAttribute("SkillLevel")]
        public int SkillLevel = 0;

        [XmlAttribute("IsApproved")]
        public Boolean IsApproved = false;

        public User(string myUserName, String myEmail, String myPassword, int myTotalScore, int mySkillLevel, Boolean myIsApproved)
        {
            UserName = myUserName;
            Email = myEmail;
            Password = myPassword;
            TotalScore = myTotalScore;
            SkillLevel = mySkillLevel;
            IsApproved = myIsApproved;
        }

        public User()
        { }

        public override string ToString()
        {
            return "UserName: " + UserName + ", Email: " + Email + ", TotalScore = " + TotalScore + ", SkillLevel = " + TotalScore + ", IsApproved = " + IsApproved;
        }

        public String GetName()
        {
            return UserName;
        }   
    }
}
