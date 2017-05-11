using System;
using System.Collections.Generic;
using System.Text;

namespace Programs_Hub.ViewModel
{

    public class DataSource
    {
        //Insatnces
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }


    }

    public class FilData
    {
        public List<DataSource> DataList
        {
            get
            {
                return CompList;
            }
        }

        public List<DataSource> CompList = new List<DataSource>();

        public void CallData()
        {
            CompList.Add(new DataSource
            {
                Id = 0,
                Name = "Eclipse",
                Image = "Assets/progPic/8.jpg"   //ms-appx:///Assets/sam1.png

            });

            CompList.Add(new DataSource
            {
                Id = 1,
                Name = "Wampp",
                Image = "Assets/progPic/1.png",
            });

            CompList.Add(new DataSource
            {
                Id = 2,
                Name = "Camtasia Studio 8.5.1",
                Image = "Assets/progPic/10.jpg",
            });

            CompList.Add(new DataSource
            {
                Id = 3,
                Name = "Geny Motion",
                Image = "Assets/progPic/2.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 4,
                Name = "netbeans",
                Image = "Assets/progPic/11.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 5,
                Name = "Foxit Reader",
                Image = "Assets/progPic/3.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 6,
                Name = "Adobe Flash Player",
                Image = "Assets/progPic/4.png",
            });
            CompList.Add(new DataSource
            {
                Id = 7,
                Name = "VLC",
                Image = "Assets/progPic/6.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 8,
                Name = "Team Veiwer",
                Image = "Assets/progPic/14.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 9,
                Name = "Photo Shop CC 2014 ",
                Image = "Assets/progPic/9.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 10,
                Name = "Virtual Box",
                Image = "Assets/progPic/16.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 11,
                Name = "DirectX",
                Image = "Assets/progPic/12.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 12,
                Name = "EaseUS Data Recovery Wizard",
                Image = "Assets/vaio.png",
            });
            CompList.Add(new DataSource
            {
                Id = 13,
                Name = "Line",
                Image = "Assets/progPic/13.jpg",
            });
            CompList.Add(new DataSource
            {
                Id = 14,
                Name = "Winrar",
                Image = "Assets/progPic/7.jpg",
            });

            CompList.Add(new DataSource
            {
                Id = 15,
                Name = "Code Blocks 13.12",
                Image = "Assets/progPic/5.png",
            });

        }
    }
}
