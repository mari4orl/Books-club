﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Booksclub
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Книга.
    /// </summary>
    // *** Start programmer edit section *** (Kniga CustomAttributes)

    // *** End programmer edit section *** (Kniga CustomAttributes)
    [AutoAltered()]
    [Caption("Книга")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("KnigaE", new string[] {
            "Nazvanie as \'Название\'",
            "Avtor as \'Автор\'",
            "KolichestvoStranic as \'Количество страниц\'",
            "URLOblozhki as \'U r l обложки\'",
            "URLOpisaniya as \'U r l описания\'",
            "Tegi as \'Теги\'",
            "SrednyayaOcenka as \'Средняя оценка\'"})]
    [View("KnigaL", new string[] {
            "Nazvanie as \'Название\'",
            "Avtor as \'Автор\'",
            "KolichestvoStranic as \'Количество страниц\'",
            "URLOblozhki as \'U r l обложки\'",
            "URLOpisaniya as \'U r l описания\'",
            "Tegi as \'Теги\'",
            "SrednyayaOcenka as \'Средняя оценка\'"})]
    public class Kniga : ICSSoft.STORMNET.DataObject
    {
        
        private string fNazvanie;
        
        private string fAvtor;
        
        private int fKolichestvoStranic;
        
        private string fURLOblozhki;
        
        private string fURLOpisaniya;
        
        private string fTegi;
        
        // *** Start programmer edit section *** (Kniga CustomMembers)

        // *** End programmer edit section *** (Kniga CustomMembers)

        
        /// <summary>
        /// Nazvanie.
        /// </summary>
        // *** Start programmer edit section *** (Kniga.Nazvanie CustomAttributes)

        // *** End programmer edit section *** (Kniga.Nazvanie CustomAttributes)
        [StrLen(255)]
        public virtual string Nazvanie
        {
            get
            {
                // *** Start programmer edit section *** (Kniga.Nazvanie Get start)

                // *** End programmer edit section *** (Kniga.Nazvanie Get start)
                string result = this.fNazvanie;
                // *** Start programmer edit section *** (Kniga.Nazvanie Get end)

                // *** End programmer edit section *** (Kniga.Nazvanie Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Kniga.Nazvanie Set start)

                // *** End programmer edit section *** (Kniga.Nazvanie Set start)
                this.fNazvanie = value;
                // *** Start programmer edit section *** (Kniga.Nazvanie Set end)

                // *** End programmer edit section *** (Kniga.Nazvanie Set end)
            }
        }
        
        /// <summary>
        /// Avtor.
        /// </summary>
        // *** Start programmer edit section *** (Kniga.Avtor CustomAttributes)

        // *** End programmer edit section *** (Kniga.Avtor CustomAttributes)
        [StrLen(255)]
        public virtual string Avtor
        {
            get
            {
                // *** Start programmer edit section *** (Kniga.Avtor Get start)

                // *** End programmer edit section *** (Kniga.Avtor Get start)
                string result = this.fAvtor;
                // *** Start programmer edit section *** (Kniga.Avtor Get end)

                // *** End programmer edit section *** (Kniga.Avtor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Kniga.Avtor Set start)

                // *** End programmer edit section *** (Kniga.Avtor Set start)
                this.fAvtor = value;
                // *** Start programmer edit section *** (Kniga.Avtor Set end)

                // *** End programmer edit section *** (Kniga.Avtor Set end)
            }
        }
        
        /// <summary>
        /// KolichestvoStranic.
        /// </summary>
        // *** Start programmer edit section *** (Kniga.KolichestvoStranic CustomAttributes)

        // *** End programmer edit section *** (Kniga.KolichestvoStranic CustomAttributes)
        public virtual int KolichestvoStranic
        {
            get
            {
                // *** Start programmer edit section *** (Kniga.KolichestvoStranic Get start)

                // *** End programmer edit section *** (Kniga.KolichestvoStranic Get start)
                int result = this.fKolichestvoStranic;
                // *** Start programmer edit section *** (Kniga.KolichestvoStranic Get end)

                // *** End programmer edit section *** (Kniga.KolichestvoStranic Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Kniga.KolichestvoStranic Set start)

                // *** End programmer edit section *** (Kniga.KolichestvoStranic Set start)
                this.fKolichestvoStranic = value;
                // *** Start programmer edit section *** (Kniga.KolichestvoStranic Set end)

                // *** End programmer edit section *** (Kniga.KolichestvoStranic Set end)
            }
        }
        
        /// <summary>
        /// URLOblozhki.
        /// </summary>
        // *** Start programmer edit section *** (Kniga.URLOblozhki CustomAttributes)

        // *** End programmer edit section *** (Kniga.URLOblozhki CustomAttributes)
        [StrLen(255)]
        public virtual string URLOblozhki
        {
            get
            {
                // *** Start programmer edit section *** (Kniga.URLOblozhki Get start)

                // *** End programmer edit section *** (Kniga.URLOblozhki Get start)
                string result = this.fURLOblozhki;
                // *** Start programmer edit section *** (Kniga.URLOblozhki Get end)

                // *** End programmer edit section *** (Kniga.URLOblozhki Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Kniga.URLOblozhki Set start)

                // *** End programmer edit section *** (Kniga.URLOblozhki Set start)
                this.fURLOblozhki = value;
                // *** Start programmer edit section *** (Kniga.URLOblozhki Set end)

                // *** End programmer edit section *** (Kniga.URLOblozhki Set end)
            }
        }
        
        /// <summary>
        /// URLOpisaniya.
        /// </summary>
        // *** Start programmer edit section *** (Kniga.URLOpisaniya CustomAttributes)

        // *** End programmer edit section *** (Kniga.URLOpisaniya CustomAttributes)
        [StrLen(255)]
        public virtual string URLOpisaniya
        {
            get
            {
                // *** Start programmer edit section *** (Kniga.URLOpisaniya Get start)

                // *** End programmer edit section *** (Kniga.URLOpisaniya Get start)
                string result = this.fURLOpisaniya;
                // *** Start programmer edit section *** (Kniga.URLOpisaniya Get end)

                // *** End programmer edit section *** (Kniga.URLOpisaniya Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Kniga.URLOpisaniya Set start)

                // *** End programmer edit section *** (Kniga.URLOpisaniya Set start)
                this.fURLOpisaniya = value;
                // *** Start programmer edit section *** (Kniga.URLOpisaniya Set end)

                // *** End programmer edit section *** (Kniga.URLOpisaniya Set end)
            }
        }
        
        /// <summary>
        /// Tegi.
        /// </summary>
        // *** Start programmer edit section *** (Kniga.Tegi CustomAttributes)

        // *** End programmer edit section *** (Kniga.Tegi CustomAttributes)
        [StrLen(255)]
        public virtual string Tegi
        {
            get
            {
                // *** Start programmer edit section *** (Kniga.Tegi Get start)

                // *** End programmer edit section *** (Kniga.Tegi Get start)
                string result = this.fTegi;
                // *** Start programmer edit section *** (Kniga.Tegi Get end)

                // *** End programmer edit section *** (Kniga.Tegi Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Kniga.Tegi Set start)

                // *** End programmer edit section *** (Kniga.Tegi Set start)
                this.fTegi = value;
                // *** Start programmer edit section *** (Kniga.Tegi Set end)

                // *** End programmer edit section *** (Kniga.Tegi Set end)
            }
        }
        
        /// <summary>
        /// SrednyayaOcenka.
        /// </summary>
        // *** Start programmer edit section *** (Kniga.SrednyayaOcenka CustomAttributes)

        // *** End programmer edit section *** (Kniga.SrednyayaOcenka CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual double SrednyayaOcenka
        {
            get
            {
                // *** Start programmer edit section *** (Kniga.SrednyayaOcenka Get)

                return 0;
                // *** End programmer edit section *** (Kniga.SrednyayaOcenka Get)
            }
            set
            {
                // *** Start programmer edit section *** (Kniga.SrednyayaOcenka Set)

                // *** End programmer edit section *** (Kniga.SrednyayaOcenka Set)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "KnigaE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View KnigaE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("KnigaE", typeof(IIS.Booksclub.Kniga));
                }
            }
            
            /// <summary>
            /// "KnigaL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View KnigaL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("KnigaL", typeof(IIS.Booksclub.Kniga));
                }
            }
        }
    }
}
