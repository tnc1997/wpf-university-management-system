using System;
using System.Collections.Generic;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class AssignmentsSeed
    {
        public static List<Assignment> ToList()
        {
            return new List<Assignment>
            {
                Ct4005Run1Assignment1,
                Ct4005Run2Assignment1,
                Ct4005Run3Assignment1,
                Ct4005Run4Assignment1,
                Ct4008Run1Assignment1,
                Ct4008Run2Assignment1,
                Ct4008Run3Assignment1,
                Ct4008Run4Assignment1,
                Ct4009Run1Assignment1,
                Ct4009Run2Assignment1,
                Ct4009Run3Assignment1,
                Ct4009Run4Assignment1,
                Ct4010Run1Assignment1,
                Ct4010Run2Assignment1,
                Ct4010Run3Assignment1,
                Ct4010Run4Assignment1,
                Ct4011Run1Assignment1,
                Ct4011Run2Assignment1,
                Ct4011Run3Assignment1,
                Ct4011Run4Assignment1,
                Ct4012Run1Assignment1,
                Ct4012Run2Assignment1,
                Ct4012Run3Assignment1,
                Ct4012Run4Assignment1,
                Ct4014Run1Assignment1,
                Ct4014Run2Assignment1,
                Ct4014Run3Assignment1,
                Ct4014Run4Assignment1,
                Ct4016Run1Assignment1,
                Ct4016Run2Assignment1,
                Ct4016Run3Assignment1,
                Ct4016Run4Assignment1,
                Ct5006Run1Assignment1,
                Ct5006Run2Assignment1,
                Ct5006Run3Assignment1,
                Ct5006Run4Assignment1,
                Ct5008Run1Assignment1,
                Ct5008Run2Assignment1,
                Ct5008Run3Assignment1,
                Ct5008Run4Assignment1,
                Ct5009Run1Assignment1,
                Ct5009Run2Assignment1,
                Ct5009Run3Assignment1,
                Ct5009Run4Assignment1,
                Ct5012Run1Assignment1,
                Ct5012Run2Assignment1,
                Ct5012Run3Assignment1,
                Ct5012Run4Assignment1,
                Ct5016Run1Assignment1,
                Ct5016Run2Assignment1,
                Ct5016Run3Assignment1,
                Ct5016Run4Assignment1,
                Ct5017Run1Assignment1,
                Ct5017Run2Assignment1,
                Ct5017Run3Assignment1,
                Ct5017Run4Assignment1,
                Ct5018Run1Assignment1,
                Ct5018Run2Assignment1,
                Ct5018Run3Assignment1,
                Ct5018Run4Assignment1,
                Ct5022Run1Assignment1,
                Ct5022Run2Assignment1,
                Ct5022Run3Assignment1,
                Ct5022Run4Assignment1,
                Ct6005Run1Assignment1,
                Ct6005Run2Assignment1,
                Ct6005Run3Assignment1,
                Ct6005Run4Assignment1,
                Ct6013Run1Assignment1,
                Ct6013Run1Assignment2,
                Ct6013Run2Assignment1,
                Ct6013Run2Assignment2,
                Ct6013Run3Assignment1,
                Ct6013Run3Assignment2,
                Ct6013Run4Assignment1,
                Ct6013Run4Assignment2,
                Ct6028Run1Assignment1,
                Ct6028Run2Assignment1,
                Ct6028Run3Assignment1,
                Ct6028Run4Assignment1,
                Ct6038Run1Assignment1,
                Ct6038Run2Assignment1,
                Ct6038Run3Assignment1,
                Ct6038Run4Assignment1,
                Ct6039Run1Assignment1,
                Ct6039Run2Assignment1,
                Ct6039Run3Assignment1,
                Ct6039Run4Assignment1,
                Ct6042Run1Assignment1,
                Ct6042Run2Assignment1,
                Ct6042Run3Assignment1,
                Ct6042Run4Assignment1
            };
        }

        #region Ct4005

        public static Assignment Ct4005Run1Assignment1 { get; } = new Assignment
        {
            Title = "Games Production",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4005Run1
        };

        public static Assignment Ct4005Run2Assignment1 { get; } = new Assignment
        {
            Title = "Games Production",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4005Run2
        };

        public static Assignment Ct4005Run3Assignment1 { get; } = new Assignment
        {
            Title = "Games Production",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4005Run3
        };

        public static Assignment Ct4005Run4Assignment1 { get; } = new Assignment
        {
            Title = "Games Production",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4005Run4
        };

        #endregion

        #region Ct4008

        public static Assignment Ct4008Run1Assignment1 { get; } = new Assignment
        {
            Title = "Digital Media Design and Development",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4008Run1
        };

        public static Assignment Ct4008Run2Assignment1 { get; } = new Assignment
        {
            Title = "Digital Media Design and Development",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4008Run2
        };

        public static Assignment Ct4008Run3Assignment1 { get; } = new Assignment
        {
            Title = "Digital Media Design and Development",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4008Run3
        };

        public static Assignment Ct4008Run4Assignment1 { get; } = new Assignment
        {
            Title = "Digital Media Design and Development",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4008Run4
        };

        #endregion

        #region CT4009

        public static Assignment Ct4009Run1Assignment1 { get; } = new Assignment
        {
            Title = "Introduction to Web Development",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4009Run1
        };

        public static Assignment Ct4009Run2Assignment1 { get; } = new Assignment
        {
            Title = "Introduction to Web Development",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4009Run2
        };

        public static Assignment Ct4009Run3Assignment1 { get; } = new Assignment
        {
            Title = "Introduction to Web Development",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4009Run3
        };

        public static Assignment Ct4009Run4Assignment1 { get; } = new Assignment
        {
            Title = "Introduction to Web Development",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4009Run4
        };

        #endregion

        #region CT4010

        public static Assignment Ct4010Run1Assignment1 { get; } = new Assignment
        {
            Title = "Computers and Security",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4010Run1
        };

        public static Assignment Ct4010Run2Assignment1 { get; } = new Assignment
        {
            Title = "Computers and Security",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4010Run2
        };

        public static Assignment Ct4010Run3Assignment1 { get; } = new Assignment
        {
            Title = "Computers and Security",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4010Run3
        };

        public static Assignment Ct4010Run4Assignment1 { get; } = new Assignment
        {
            Title = "Computers and Security",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4010Run4
        };

        #endregion

        #region CT4011

        public static Assignment Ct4011Run1Assignment1 { get; } = new Assignment
        {
            Title = "Creative Skills for Design",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4011Run1
        };

        public static Assignment Ct4011Run2Assignment1 { get; } = new Assignment
        {
            Title = "Creative Skills for Design",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4011Run2
        };

        public static Assignment Ct4011Run3Assignment1 { get; } = new Assignment
        {
            Title = "Creative Skills for Design",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4011Run3
        };

        public static Assignment Ct4011Run4Assignment1 { get; } = new Assignment
        {
            Title = "Creative Skills for Design",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4011Run4
        };

        #endregion

        #region CT4012

        public static Assignment Ct4012Run1Assignment1 { get; } = new Assignment
        {
            Title = "Introduction to 3D Modelling",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4012Run1
        };

        public static Assignment Ct4012Run2Assignment1 { get; } = new Assignment
        {
            Title = "Introduction to 3D Modelling",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4012Run2
        };

        public static Assignment Ct4012Run3Assignment1 { get; } = new Assignment
        {
            Title = "Introduction to 3D Modelling",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4012Run3
        };

        public static Assignment Ct4012Run4Assignment1 { get; } = new Assignment
        {
            Title = "Introduction to 3D Modelling",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4012Run4
        };

        #endregion

        #region CT4014

        public static Assignment Ct4014Run1Assignment1 { get; } = new Assignment
        {
            Title = "Human Factors",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4014Run1
        };

        public static Assignment Ct4014Run2Assignment1 { get; } = new Assignment
        {
            Title = "Human Factors",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4014Run2
        };

        public static Assignment Ct4014Run3Assignment1 { get; } = new Assignment
        {
            Title = "Human Factors",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4014Run3
        };

        public static Assignment Ct4014Run4Assignment1 { get; } = new Assignment
        {
            Title = "Human Factors",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct4014Run4
        };

        #endregion

        #region CT4016

        public static Assignment Ct4016Run1Assignment1 { get; } = new Assignment
        {
            Title = "Materials & Manufacturing for Product Design",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4016Run1
        };

        public static Assignment Ct4016Run2Assignment1 { get; } = new Assignment
        {
            Title = "Materials & Manufacturing for Product Design",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4016Run2
        };

        public static Assignment Ct4016Run3Assignment1 { get; } = new Assignment
        {
            Title = "Materials & Manufacturing for Product Design",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4016Run3
        };

        public static Assignment Ct4016Run4Assignment1 { get; } = new Assignment
        {
            Title = "Materials & Manufacturing for Product Design",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct4016Run4
        };

        #endregion

        #region CT5006

        public static Assignment Ct5006Run1Assignment1 { get; } = new Assignment
        {
            Title = "Mobile Application Development",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5006Run1
        };

        public static Assignment Ct5006Run2Assignment1 { get; } = new Assignment
        {
            Title = "Mobile Application Development",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5006Run2
        };

        public static Assignment Ct5006Run3Assignment1 { get; } = new Assignment
        {
            Title = "Mobile Application Development",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5006Run3
        };

        public static Assignment Ct5006Run4Assignment1 { get; } = new Assignment
        {
            Title = "Mobile Application Development",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5006Run4
        };

        #endregion

        #region CT5008

        public static Assignment Ct5008Run1Assignment1 { get; } = new Assignment
        {
            Title = "3D Animations for Games",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5008Run1
        };

        public static Assignment Ct5008Run2Assignment1 { get; } = new Assignment
        {
            Title = "3D Animations for Games",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5008Run2
        };

        public static Assignment Ct5008Run3Assignment1 { get; } = new Assignment
        {
            Title = "3D Animations for Games",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5008Run3
        };

        public static Assignment Ct5008Run4Assignment1 { get; } = new Assignment
        {
            Title = "3D Animations for Games",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5008Run4
        };

        #endregion

        #region CT5009

        public static Assignment Ct5009Run1Assignment1 { get; } = new Assignment
        {
            Title = "Game Engine Programming",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5009Run1
        };

        public static Assignment Ct5009Run2Assignment1 { get; } = new Assignment
        {
            Title = "Game Engine Programming",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5009Run2
        };

        public static Assignment Ct5009Run3Assignment1 { get; } = new Assignment
        {
            Title = "Game Engine Programming",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5009Run3
        };

        public static Assignment Ct5009Run4Assignment1 { get; } = new Assignment
        {
            Title = "Game Engine Programming",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5009Run4
        };

        #endregion

        #region CT5012

        public static Assignment Ct5012Run1Assignment1 { get; } = new Assignment
        {
            Title = "User Interaction Studies",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5012Run1
        };

        public static Assignment Ct5012Run2Assignment1 { get; } = new Assignment
        {
            Title = "User Interaction Studies",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5012Run2
        };

        public static Assignment Ct5012Run3Assignment1 { get; } = new Assignment
        {
            Title = "User Interaction Studies",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5012Run3
        };

        public static Assignment Ct5012Run4Assignment1 { get; } = new Assignment
        {
            Title = "User Interaction Studies",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5012Run4
        };

        #endregion

        #region CT5016

        public static Assignment Ct5016Run1Assignment1 { get; } = new Assignment
        {
            Title = "Level Design",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5016Run1
        };

        public static Assignment Ct5016Run2Assignment1 { get; } = new Assignment
        {
            Title = "Level Design",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5016Run2
        };

        public static Assignment Ct5016Run3Assignment1 { get; } = new Assignment
        {
            Title = "Level Design",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5016Run3
        };

        public static Assignment Ct5016Run4Assignment1 { get; } = new Assignment
        {
            Title = "Level Design",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5016Run4
        };

        #endregion

        #region CT5017

        public static Assignment Ct5017Run1Assignment1 { get; } = new Assignment
        {
            Title = "Multimedia Web Development",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5018Run1
        };

        public static Assignment Ct5017Run2Assignment1 { get; } = new Assignment
        {
            Title = "Multimedia Web Development",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5017Run2
        };

        public static Assignment Ct5017Run3Assignment1 { get; } = new Assignment
        {
            Title = "Multimedia Web Development",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5017Run3
        };

        public static Assignment Ct5017Run4Assignment1 { get; } = new Assignment
        {
            Title = "Multimedia Web Development",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5017Run4
        };

        #endregion

        #region CT5018

        public static Assignment Ct5018Run1Assignment1 { get; } = new Assignment
        {
            Title = "Data Analytics",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5018Run1
        };

        public static Assignment Ct5018Run2Assignment1 { get; } = new Assignment
        {
            Title = "Data Analytics",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5018Run2
        };

        public static Assignment Ct5018Run3Assignment1 { get; } = new Assignment
        {
            Title = "Data Analytics",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5018Run3
        };

        public static Assignment Ct5018Run4Assignment1 { get; } = new Assignment
        {
            Title = "Data Analytics",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 1, 18, 0, 0),
            Run = RunsSeed.Ct5018Run4
        };

        #endregion

        #region CT5022

        public static Assignment Ct5022Run1Assignment1 { get; } = new Assignment
        {
            Title = "Project Management",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5022Run1
        };

        public static Assignment Ct5022Run2Assignment1 { get; } = new Assignment
        {
            Title = "Project Management",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5022Run2
        };

        public static Assignment Ct5022Run3Assignment1 { get; } = new Assignment
        {
            Title = "Project Management",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5022Run3
        };

        public static Assignment Ct5022Run4Assignment1 { get; } = new Assignment
        {
            Title = "Project Management",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 1, 18, 0, 0),
            Run = RunsSeed.Ct5022Run4
        };

        #endregion

        #region CT6005

        public static Assignment Ct6005Run1Assignment1 { get; } = new Assignment
        {
            Title = "Software Quality Assurance",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 8, 18, 0, 0),
            Run = RunsSeed.Ct6005Run1
        };

        public static Assignment Ct6005Run2Assignment1 { get; } = new Assignment
        {
            Title = "Software Quality Assurance",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 8, 18, 0, 0),
            Run = RunsSeed.Ct6005Run2
        };

        public static Assignment Ct6005Run3Assignment1 { get; } = new Assignment
        {
            Title = "Software Quality Assurance",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 8, 18, 0, 0),
            Run = RunsSeed.Ct6005Run3
        };

        public static Assignment Ct6005Run4Assignment1 { get; } = new Assignment
        {
            Title = "Software Quality Assurance",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 8, 18, 0, 0),
            Run = RunsSeed.Ct6005Run4
        };

        #endregion

        #region CT6013

        public static Assignment Ct6013Run1Assignment1 { get; } = new Assignment
        {
            Title = "Student Records",
            Details = "N/A",
            Deadline = new DateTime(2015, 12, 13, 18, 0, 0),
            Run = RunsSeed.Ct6013Run1
        };

        public static Assignment Ct6013Run1Assignment2 { get; } = new Assignment
        {
            Title = "University Management System",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 13, 18, 0, 0),
            Run = RunsSeed.Ct6013Run1
        };

        public static Assignment Ct6013Run2Assignment1 { get; } = new Assignment
        {
            Title = "Student Records",
            Details = "N/A",
            Deadline = new DateTime(2016, 12, 13, 18, 0, 0),
            Run = RunsSeed.Ct6013Run2
        };

        public static Assignment Ct6013Run2Assignment2 { get; } = new Assignment
        {
            Title = "University Management System",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 13, 18, 0, 0),
            Run = RunsSeed.Ct6013Run2
        };

        public static Assignment Ct6013Run3Assignment1 { get; } = new Assignment
        {
            Title = "Student Records",
            Details = "N/A",
            Deadline = new DateTime(2017, 12, 13, 18, 0, 0),
            Run = RunsSeed.Ct6013Run3
        };

        public static Assignment Ct6013Run3Assignment2 { get; } = new Assignment
        {
            Title = "University Management System",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 13, 18, 0, 0),
            Run = RunsSeed.Ct6013Run3
        };

        public static Assignment Ct6013Run4Assignment1 { get; } = new Assignment
        {
            Title = "Student Records",
            Details = "N/A",
            Deadline = new DateTime(2018, 12, 13, 18, 0, 0),
            Run = RunsSeed.Ct6013Run4
        };

        public static Assignment Ct6013Run4Assignment2 { get; } = new Assignment
        {
            Title = "University Management System",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 13, 18, 0, 0),
            Run = RunsSeed.Ct6013Run4
        };

        #endregion

        #region CT6028

        public static Assignment Ct6028Run1Assignment1 { get; } = new Assignment
        {
            Title = "Organisational Agility",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 10, 18, 0, 0),
            Run = RunsSeed.Ct6028Run1
        };

        public static Assignment Ct6028Run2Assignment1 { get; } = new Assignment
        {
            Title = "Organisational Agility",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 10, 18, 0, 0),
            Run = RunsSeed.Ct6028Run2
        };

        public static Assignment Ct6028Run3Assignment1 { get; } = new Assignment
        {
            Title = "Organisational Agility",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 10, 18, 0, 0),
            Run = RunsSeed.Ct6028Run3
        };

        public static Assignment Ct6028Run4Assignment1 { get; } = new Assignment
        {
            Title = "Organisational Agility",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 10, 18, 0, 0),
            Run = RunsSeed.Ct6028Run4
        };

        #endregion

        #region CT6038

        public static Assignment Ct6038Run1Assignment1 { get; } = new Assignment
        {
            Title = "Dissertation Proposal",
            Details = "N/A",
            Deadline = new DateTime(2015, 12, 5, 18, 0, 0),
            Run = RunsSeed.Ct6038Run1
        };

        public static Assignment Ct6038Run2Assignment1 { get; } = new Assignment
        {
            Title = "Dissertation Proposal",
            Details = "N/A",
            Deadline = new DateTime(2016, 12, 5, 18, 0, 0),
            Run = RunsSeed.Ct6038Run2
        };

        public static Assignment Ct6038Run3Assignment1 { get; } = new Assignment
        {
            Title = "Dissertation Proposal",
            Details = "N/A",
            Deadline = new DateTime(2017, 12, 5, 18, 0, 0),
            Run = RunsSeed.Ct6038Run3
        };

        public static Assignment Ct6038Run4Assignment1 { get; } = new Assignment
        {
            Title = "Dissertation Proposal",
            Details = "N/A",
            Deadline = new DateTime(2018, 12, 5, 18, 0, 0),
            Run = RunsSeed.Ct6038Run4
        };

        #endregion

        #region CT6039

        public static Assignment Ct6039Run1Assignment1 { get; } = new Assignment
        {
            Title = "Dissertation",
            Details = "N/A",
            Deadline = new DateTime(2016, 5, 2, 18, 0, 0),
            Run = RunsSeed.Ct6039Run1
        };

        public static Assignment Ct6039Run2Assignment1 { get; } = new Assignment
        {
            Title = "Dissertation",
            Details = "N/A",
            Deadline = new DateTime(2017, 5, 2, 18, 0, 0),
            Run = RunsSeed.Ct6039Run2
        };

        public static Assignment Ct6039Run3Assignment1 { get; } = new Assignment
        {
            Title = "Dissertation",
            Details = "N/A",
            Deadline = new DateTime(2018, 5, 2, 18, 0, 0),
            Run = RunsSeed.Ct6039Run3
        };

        public static Assignment Ct6039Run4Assignment1 { get; } = new Assignment
        {
            Title = "Dissertation",
            Details = "N/A",
            Deadline = new DateTime(2019, 5, 2, 18, 0, 0),
            Run = RunsSeed.Ct6039Run4
        };

        #endregion

        #region CT6042

        public static Assignment Ct6042Run1Assignment1 { get; } = new Assignment
        {
            Title = "Security Vulnerabilities",
            Details = "N/A",
            Deadline = new DateTime(2016, 1, 8, 18, 0, 0),
            Run = RunsSeed.Ct6042Run1
        };

        public static Assignment Ct6042Run2Assignment1 { get; } = new Assignment
        {
            Title = "Security Vulnerabilities",
            Details = "N/A",
            Deadline = new DateTime(2017, 1, 8, 18, 0, 0),
            Run = RunsSeed.Ct6042Run2
        };

        public static Assignment Ct6042Run3Assignment1 { get; } = new Assignment
        {
            Title = "Security Vulnerabilities",
            Details = "N/A",
            Deadline = new DateTime(2018, 1, 8, 18, 0, 0),
            Run = RunsSeed.Ct6042Run3
        };

        public static Assignment Ct6042Run4Assignment1 { get; } = new Assignment
        {
            Title = "Security Vulnerabilities",
            Details = "N/A",
            Deadline = new DateTime(2019, 1, 8, 18, 0, 0),
            Run = RunsSeed.Ct6042Run4
        };

        #endregion
    }
}