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
    /// Доклад.
    /// </summary>
    // *** Start programmer edit section *** (Doklad CustomAttributes)

    // *** End programmer edit section *** (Doklad CustomAttributes)
    [AutoAltered()]
    [Caption("Доклад")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("DokladE", new string[] {
            "DataDoklada as \'Дата доклада\'",
            "OcenkaKnigi as \'Оценка книги\'",
            "URLPrezentacii as \'U r l презентации\'",
            "URLVideo as \'U r l видео\'",
            "Recenziya as \'Рецензия\'",
            "Spiker as \'Спикер\'",
            "Spiker.Familiya as \'\'",
            "Kniga as \'Книга\'",
            "Kniga.Nazvanie as \'\'",
            "Spiker.Imya as \'\'",
            "Spiker.Otchestvo as \'\'"}, Hidden=new string[] {
            "Spiker.Familiya",
            "Kniga.Nazvanie"})]
    [MasterViewDefineAttribute("DokladE", "Spiker", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Familiya")]
    [MasterViewDefineAttribute("DokladE", "Kniga", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Nazvanie")]
    public class Doklad : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fDataDoklada;
        
        private int fOcenkaKnigi;
        
        private string fURLPrezentacii;
        
        private string fURLVideo;
        
        private string fRecenziya;
        
        private IIS.Booksclub.Kniga fKniga;
        
        private IIS.Booksclub.Spiker fSpiker;
        
        private IIS.Booksclub.VstrechaKluba fVstrechaKluba;
        
        // *** Start programmer edit section *** (Doklad CustomMembers)

        // *** End programmer edit section *** (Doklad CustomMembers)

        
        /// <summary>
        /// DataDoklada.
        /// </summary>
        // *** Start programmer edit section *** (Doklad.DataDoklada CustomAttributes)

        // *** End programmer edit section *** (Doklad.DataDoklada CustomAttributes)
        [NotNull()]
        public virtual System.DateTime DataDoklada
        {
            get
            {
                // *** Start programmer edit section *** (Doklad.DataDoklada Get start)

                // *** End programmer edit section *** (Doklad.DataDoklada Get start)
                System.DateTime result = this.fDataDoklada;
                // *** Start programmer edit section *** (Doklad.DataDoklada Get end)

                // *** End programmer edit section *** (Doklad.DataDoklada Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Doklad.DataDoklada Set start)

                // *** End programmer edit section *** (Doklad.DataDoklada Set start)
                this.fDataDoklada = value;
                // *** Start programmer edit section *** (Doklad.DataDoklada Set end)

                // *** End programmer edit section *** (Doklad.DataDoklada Set end)
            }
        }
        
        /// <summary>
        /// OcenkaKnigi.
        /// </summary>
        // *** Start programmer edit section *** (Doklad.OcenkaKnigi CustomAttributes)

        // *** End programmer edit section *** (Doklad.OcenkaKnigi CustomAttributes)
        public virtual int OcenkaKnigi
        {
            get
            {
                // *** Start programmer edit section *** (Doklad.OcenkaKnigi Get start)

                // *** End programmer edit section *** (Doklad.OcenkaKnigi Get start)
                int result = this.fOcenkaKnigi;
                // *** Start programmer edit section *** (Doklad.OcenkaKnigi Get end)

                // *** End programmer edit section *** (Doklad.OcenkaKnigi Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Doklad.OcenkaKnigi Set start)

                // *** End programmer edit section *** (Doklad.OcenkaKnigi Set start)
                this.fOcenkaKnigi = value;
                // *** Start programmer edit section *** (Doklad.OcenkaKnigi Set end)

                // *** End programmer edit section *** (Doklad.OcenkaKnigi Set end)
            }
        }
        
        /// <summary>
        /// URLPrezentacii.
        /// </summary>
        // *** Start programmer edit section *** (Doklad.URLPrezentacii CustomAttributes)

        // *** End programmer edit section *** (Doklad.URLPrezentacii CustomAttributes)
        [StrLen(255)]
        public virtual string URLPrezentacii
        {
            get
            {
                // *** Start programmer edit section *** (Doklad.URLPrezentacii Get start)

                // *** End programmer edit section *** (Doklad.URLPrezentacii Get start)
                string result = this.fURLPrezentacii;
                // *** Start programmer edit section *** (Doklad.URLPrezentacii Get end)

                // *** End programmer edit section *** (Doklad.URLPrezentacii Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Doklad.URLPrezentacii Set start)

                // *** End programmer edit section *** (Doklad.URLPrezentacii Set start)
                this.fURLPrezentacii = value;
                // *** Start programmer edit section *** (Doklad.URLPrezentacii Set end)

                // *** End programmer edit section *** (Doklad.URLPrezentacii Set end)
            }
        }
        
        /// <summary>
        /// URLVideo.
        /// </summary>
        // *** Start programmer edit section *** (Doklad.URLVideo CustomAttributes)

        // *** End programmer edit section *** (Doklad.URLVideo CustomAttributes)
        [StrLen(255)]
        public virtual string URLVideo
        {
            get
            {
                // *** Start programmer edit section *** (Doklad.URLVideo Get start)

                // *** End programmer edit section *** (Doklad.URLVideo Get start)
                string result = this.fURLVideo;
                // *** Start programmer edit section *** (Doklad.URLVideo Get end)

                // *** End programmer edit section *** (Doklad.URLVideo Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Doklad.URLVideo Set start)

                // *** End programmer edit section *** (Doklad.URLVideo Set start)
                this.fURLVideo = value;
                // *** Start programmer edit section *** (Doklad.URLVideo Set end)

                // *** End programmer edit section *** (Doklad.URLVideo Set end)
            }
        }
        
        /// <summary>
        /// Recenziya.
        /// </summary>
        // *** Start programmer edit section *** (Doklad.Recenziya CustomAttributes)

        // *** End programmer edit section *** (Doklad.Recenziya CustomAttributes)
        [StrLen(255)]
        public virtual string Recenziya
        {
            get
            {
                // *** Start programmer edit section *** (Doklad.Recenziya Get start)

                // *** End programmer edit section *** (Doklad.Recenziya Get start)
                string result = this.fRecenziya;
                // *** Start programmer edit section *** (Doklad.Recenziya Get end)

                // *** End programmer edit section *** (Doklad.Recenziya Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Doklad.Recenziya Set start)

                // *** End programmer edit section *** (Doklad.Recenziya Set start)
                this.fRecenziya = value;
                // *** Start programmer edit section *** (Doklad.Recenziya Set end)

                // *** End programmer edit section *** (Doklad.Recenziya Set end)
            }
        }
        
        /// <summary>
        /// Доклад.
        /// </summary>
        // *** Start programmer edit section *** (Doklad.Kniga CustomAttributes)

        // *** End programmer edit section *** (Doklad.Kniga CustomAttributes)
        [NotNull()]
        public virtual IIS.Booksclub.Kniga Kniga
        {
            get
            {
                // *** Start programmer edit section *** (Doklad.Kniga Get start)

                // *** End programmer edit section *** (Doklad.Kniga Get start)
                IIS.Booksclub.Kniga result = this.fKniga;
                // *** Start programmer edit section *** (Doklad.Kniga Get end)

                // *** End programmer edit section *** (Doklad.Kniga Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Doklad.Kniga Set start)

                // *** End programmer edit section *** (Doklad.Kniga Set start)
                this.fKniga = value;
                // *** Start programmer edit section *** (Doklad.Kniga Set end)

                // *** End programmer edit section *** (Doklad.Kniga Set end)
            }
        }
        
        /// <summary>
        /// Доклад.
        /// </summary>
        // *** Start programmer edit section *** (Doklad.Spiker CustomAttributes)

        // *** End programmer edit section *** (Doklad.Spiker CustomAttributes)
        [NotNull()]
        public virtual IIS.Booksclub.Spiker Spiker
        {
            get
            {
                // *** Start programmer edit section *** (Doklad.Spiker Get start)

                // *** End programmer edit section *** (Doklad.Spiker Get start)
                IIS.Booksclub.Spiker result = this.fSpiker;
                // *** Start programmer edit section *** (Doklad.Spiker Get end)

                // *** End programmer edit section *** (Doklad.Spiker Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Doklad.Spiker Set start)

                // *** End programmer edit section *** (Doklad.Spiker Set start)
                this.fSpiker = value;
                // *** Start programmer edit section *** (Doklad.Spiker Set end)

                // *** End programmer edit section *** (Doklad.Spiker Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Booksclub.VstrechaKluba.
        /// </summary>
        // *** Start programmer edit section *** (Doklad.VstrechaKluba CustomAttributes)

        // *** End programmer edit section *** (Doklad.VstrechaKluba CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual IIS.Booksclub.VstrechaKluba VstrechaKluba
        {
            get
            {
                // *** Start programmer edit section *** (Doklad.VstrechaKluba Get start)

                // *** End programmer edit section *** (Doklad.VstrechaKluba Get start)
                IIS.Booksclub.VstrechaKluba result = this.fVstrechaKluba;
                // *** Start programmer edit section *** (Doklad.VstrechaKluba Get end)

                // *** End programmer edit section *** (Doklad.VstrechaKluba Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Doklad.VstrechaKluba Set start)

                // *** End programmer edit section *** (Doklad.VstrechaKluba Set start)
                this.fVstrechaKluba = value;
                // *** Start programmer edit section *** (Doklad.VstrechaKluba Set end)

                // *** End programmer edit section *** (Doklad.VstrechaKluba Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "DokladE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DokladE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DokladE", typeof(IIS.Booksclub.Doklad));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Doklad.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfDoklad CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfDoklad CustomAttributes)
    public class DetailArrayOfDoklad : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Booksclub.DetailArrayOfDoklad members)

        // *** End programmer edit section *** (IIS.Booksclub.DetailArrayOfDoklad members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Doklad by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Doklad.
        /// </summary>
        public DetailArrayOfDoklad(IIS.Booksclub.VstrechaKluba fVstrechaKluba) : 
                base(typeof(Doklad), ((ICSSoft.STORMNET.DataObject)(fVstrechaKluba)))
        {
        }
        
        public IIS.Booksclub.Doklad this[int index]
        {
            get
            {
                return ((IIS.Booksclub.Doklad)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Booksclub.Doklad dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
