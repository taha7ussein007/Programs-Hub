using System;
using System.Collections.Generic;
using System.Text;

namespace Programs_Hub.Model
{
    public class prog1
    {
        public int ID { get; set; }
        public string PName { get; set; }
        public string PImage { get; set; }
        public string desc { get; set; }
        public string mini_desc { get; set; }
        public string link { get; set; }
        public string dowl { get; set; }


    }


    public class Data2
    {
        public List<prog1> myList2
        {
            get
            {
                return privateList;
            }
        }

        private List<prog1> privateList = new List<prog1>();


        public void Data_in()
        {
            myList2.Add(new prog1()
            {
                ID = 0,
                PName = "Eclipse",
                PImage = "Assets/progPic/8.jpg",
                mini_desc = "Programe to get started in php , \n java programing like netbeans . ",
                desc = "The essential tools for any Java developer,\nincluding a Java IDE,\n CVS client,Git client, XML Editor, Mylyn,\nMaven integration and WindowBuilder.\n.................\nPrecondition is installing\njava jdk : http://bit.ly/1lO1FSV\n" ,
                link = "35NUuhmQuB4",
                dowl = "http://bit.ly/18ub3Xx"
            });



            myList2.Add(new prog1()
            {
                ID = 1,
                PName = "Wampp",
                PImage = "Assets/progPic/1.png",
                mini_desc = ": Tool which help you to test dynamic websites , \n includes MySQL , PHP and Apache (or 'Apache HTTP Server')\n which is used run the web server within Windows.",
                desc = "Stands for\n'Windows, Apache, MySQL, and PHP'.\n WAMP is a variation of LAMP for \nWindows systems and is often \ninstalled as a software bundle\n(Apache, MySQL, and PHP). It is often \nused for web development and \ninternal testing, but may also\nbe used to serve live websites." ,
                link = "kVc_9vAO7oI",
                dowl = "http://bit.ly/1eQ3iQ3"
            });


            myList2.Add(new prog1()
            {
                ID = 2,
                PName = "Camtasia Studio 8.5.1",
                PImage = "Assets/progPic/10.jpg",
                mini_desc = "Programe that you can use it to record the screen , \n edit vedios and share it easily .",
                desc = "Programe that you can use to  Record \nhigh-quality videos in no time\nwith Camtasia's advanced screen \nrecorder , Create more professional videos without \nhaving to be a video pro ,Easily share your \nvideos and interact with your audience. " ,
                link = "7fcw8i89nqo",
                dowl = "http://bit.ly/1TP6xtd"
            });

            myList2.Add(new prog1()
            {
                ID = 3,
                PName = "Geny Motion",
                PImage = "Assets/progPic/2.jpg",
                mini_desc = "Genymotion is a fast and easy-to-use \n  Android emulator to run and test your Android apps .",
                desc = "Genymotion is an Android emulator for building and\ntesting great Android apps. It’s fast, simple and \npowerful.It offers 20 pre-configured\ndevices\nand you can create your own custom ones. \n.............\nprecondition is installing virtual machine.",
                link = "5MypWPkXaDw",
                dowl = "http://bit.ly/1HjwYln"
            });

            myList2.Add(new prog1()
            {
                ID = 4,
                PName = "netbeans",
                PImage = "Assets/progPic/11.jpeg",
                mini_desc = "Programe to get started in php ,\n java , c++ , HTML programing  like eclipse .",
                desc = "NetBeans IDE is the official IDE for Java 8.\n With its editors, code analyzers, and converters, you can \nquickly and smoothly upgrade your applicationsto \nuse new Java 8 language constructs,\n such as lambdas, functional operations,and method references. \n.................\n Precondition is installing < java jdk >.",
                link = "LTaKGT4q6JY",
                dowl = "http://bit.ly/1daNBmX"

            });

            myList2.Add(new prog1()
            {
                ID = 5,
                PName = "Foxit Reader",
                PImage = "Assets/progPic/3.jpg",
                mini_desc = "PDF Reader: Print and View PDF Foxit Reader .",
                desc = "Over 325 Million UsersSmall, Fast, and Feature RichFree PDF \nCreation / PDF ConversionProtects Against Security \nVulnerabilitiesEasily Deployable to Large Organizations ." ,
                link = "kholVJTcpqE",
                dowl = "http://bit.ly/1uq5zcV" 
            });

            myList2.Add(new prog1()
            {
                ID = 6,
                PName = "Adobe Flash Player",
                PImage = "Assets/progPic/4.png",
                mini_desc = "A programe to be able to watch \n  youtube or other streaming video on internet . ",
                desc = "is freeware software for using content \ncreated on the Adobe Flash platform, including viewing multimedia, \nexecuting rich Internet applications, \nand streaming video and audio." ,
                link = "qMqmLj-SS9o",
                dowl = "http://bit.ly/1e5KfCR"
            });
            myList2.Add(new prog1()
            {
                ID = 7,
                PName = "VLC",
                PImage = "Assets/progPic/6.jpg",
                mini_desc = "It is video media player to get started \n with movies and videos that you own on your computer .",
                desc = "VLC media player (initially VideoLAN Client) is a highly \nportable multimedia player for various audio and video formats \n(MPEG, DivX/Xvid, Ogg, and many more) \nas well as DVDs, VCDs, and various \nstreaming protocols." ,
                link = "_3JN-EPLpy0",
                dowl = "http://bit.ly/1jWHeUd"
            });
            myList2.Add(new prog1()
            {
                ID = 8,
                PName = "Team Veiwer",
                PImage = "Assets/progPic/14.jpg",
                mini_desc = "Programe to get started with remaote - \n access to controls any \ncomputer have team veiwer just by password .",
                desc = "TeamViewer is a proprietary computer \nsoftware package for remote control,\ndesktop sharing, online meetings, \nweb conferencing and file transfer\nbetween computers." ,
                link = "r8krrmJ26U4",
                dowl = "http://bit.ly/1LRJc4w"
            });
            myList2.Add(new prog1()
            {
                ID = 9,
                PName = "Photo Shop CC 2014 ",
                PImage = "Assets/progPic/9.jpg",
                mini_desc = "Programe that you can use it to edit photos \n and pictures and  to create amazing projects , logos and designs .",
                desc = " The world's best imaging and design app \nnow features even more creative possibilities \nwith new tools for design and photography, \nconnecting your desktop and mobile apps with \nall your creative assets, \nso you can make amazing visual \ncontent on any device." ,
                link = "DhsywizgcZc",
                dowl = "http://bit.ly/1GW7N72" 
            });
            myList2.Add(new prog1()
            {
                ID = 10,
                PName = "Virtual Box",
                PImage = "Assets/progPic/17.jpg",
                mini_desc = "It is a virtual machine that you can instal \n any operating system beside yours \nand specify part from your RAM to it .",
                desc = "VirtualBox is a cross-platform \nvirtualization application. \nFor one thing, it installs on your \nexisting Intel or AMD-based computers, \nwhether they are running Windows,\n Mac, Linux or Solaris \noperating systems." ,
                link = "WIPJL-Ot-gU",
                dowl = "http://bit.ly/1p6Pn8w"
            });
            myList2.Add(new prog1()
            {
                ID =11,
                PName = "DirectX 11",
                PImage = "Assets/progPic/12.jpg",
                mini_desc = "Programe to get started with computer \n Games and movies or \n videos with high Quality .",
                desc = "Microsoft DirectX is the graphics technology\npowering today’s most impressive games. The latest version, \nDirectX 11, enables the addition of advanced effects \nand features in NVIDIA-enhanced titles,\nranging from tessellation and HBAO+,\nto Percentage Closer Soft Shadows\nand NVIDA HairWorks. " ,
                link = "7qMo9SfBIRY",
                dowl = "http://bit.ly/1g4u0at" 
            });
            myList2.Add(new prog1()
            {
                ID = 12,
                PName = "EaseUS Data Recovery",
                PImage = "Assets/progPic/16.jpg",
                mini_desc = "A programe that you can use it to resize \n your hard ,data recovery,\n formatting and many \nseveral Uses .",
                desc = "Geared mainly toward recovering from accidental file deletions or disk \nformats, EaseUS' product also includes \nsupport for data corruption brought about by unexpected crashes, \nloss of power…-By Jesus Vigo, \nTechRepublic ." ,
                link = "8mOfW79wGTo",
                dowl = "http://cnet.co/1BShZOM" 
            });
            myList2.Add(new prog1()
            {
                ID = 13,
                PName = "LINE",
                PImage = "Assets/progPic/13.jpg",
                mini_desc = "Free Application for communications \n Like Skype , it also support images ,  \n photos and audio .",
                desc = "Line (styled 'LINE') is a proprietary \napplication for instant \ncommunications on electronic devices\nsuch as smartphones, tablet computers\nand personal computers.",
                link = "v2VHVOpzjYs",
                dowl = "http://bit.ly/1HrlgW1"
            });
            myList2.Add(new prog1()
            {
                ID = 14,
                PName = "Code Blocks 13.12",
                PImage = "Assets/progPic/5.png",
                mini_desc = "It is a free C, C++ and Fortran IDE  \n built to meet the most demanding \n needs of its users.",
                desc = "Code::Blocks is a free C, C++ and Fortran IDE\n built to meet the most demanding needs of its users. \n It is designed to be very extensible \nand fully configurable." ,
                link = "zOGU8fC3bvU",
                dowl = "http://bit.ly/1w64VQo"
            });
            myList2.Add(new prog1()
            {
                ID = 15,
                PName = "WinRAR",
                PImage = "Assets/progPic/7.jpg",
                mini_desc = "It is a shareware file archiver \nand compressor utility\nfor Windows.",
                desc = "WinRAR is a shareware file archiver and compressor utility for Windows, \nIt can create archives in RAR or ZIP file formats,\nand unpack numerous archive file formats" ,
                link = "IOvuW94el8w",
                dowl = "http://bit.ly/1LETR5F"
            });


        }
    }
}
