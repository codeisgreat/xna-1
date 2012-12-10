using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Library
{
    public enum Skill
    {
        Beginner,
        Intermediate,
        Advanced
    }

    public class User
    {
        [XmlAttribute("UserName")]
        public String UserName = "";

        [XmlAttribute("ImageURL")]
        public String ImageURL = "";

        [XmlAttribute("Email")]
        public String Email = "";

        [XmlAttribute("Password")]
        public String Password = "";

        [XmlAttribute("TotalWins")]
        public int TotalWins = 0;

        [XmlAttribute("TotalGames")]
        public int TotalGames = 0;

        [XmlAttribute("SkillLevel")]
        public int SkillLevel = 0;

        [XmlAttribute("IsApproved")]
        public Boolean IsApproved;

        [XmlAttribute("Balance")]
        public Double Balance = 0.0;

        [XmlAttribute("CostPerGame")]
        public Double CostPerGame = 1.0;

        public void Lost()
        {
            TotalGames++;
            SkillLevel = 0;
            UpdateSkill();
            UpdateBalance();
        }

        /// <summary>
        /// Return User's Skill
        /// </summary>
        /// <returns></returns>

        public Skill GetSkill()
        {
            return (Skill)SkillLevel;
        }

        public void Won()
        {
            TotalGames++;
            TotalWins++;
            UpdateSkill();
            UpdateBalance();
        }
        /// <summary>
        /// Automatically Updates Skill Level, after Each Game Lost or Game Won. If Win Ratio drops below 50% Skill Level is set to 0 (Beginner)
        /// Greater than 50% is Intermediate
        /// Greater than 75% is Advanced
        /// </summary>
        public void UpdateSkill()
        {
            Double Result = Convert.ToDouble(TotalWins) / Convert.ToDouble(TotalGames);
            SkillLevel = 0;
            CostPerGame = 1.0;
            if (Result > 0.5)
            {
                SkillLevel = 1;
                CostPerGame = 0.5;
            }
            if (Result > 0.75)
            {
                SkillLevel = 2;
                CostPerGame = 0.25;
            }
        }

        public void UpdateBalance()
        {
            Balance = Balance - CostPerGame;
        }

        public User(string myUserName, String myEmail, String myPassword, int myTotalScore, int mySkillLevel, Boolean myIsApproved)
        {
            UserName = myUserName;
            Email = myEmail;
            Password = myPassword;
            TotalGames = myTotalScore;
            SkillLevel = mySkillLevel;
            IsApproved = myIsApproved;
        }

        public User()
        { }

        public override string ToString()
        {
            return "UserName: " + UserName + ", Email: " + Email + ", TotalGames = " + TotalGames + ", SkillLevel = " + SkillLevel + ", IsApproved = " + IsApproved;
        }

        public String GetName()
        {
            return UserName;
        }   
    }
}
