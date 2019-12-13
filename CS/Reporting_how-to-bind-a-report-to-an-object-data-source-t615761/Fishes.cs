using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using DevExpress.DataAccess.ObjectBinding;


namespace ObjectDataSource {
    [DisplayName("Fishes")]
    [HighlightedClass]
    public class Fishes : List<Fish> {
        [HighlightedMember]
        public Fishes(string filePath) {
            string path = AppDomain.CurrentDomain.GetData("DataDirectory") as string;
            if (!string.IsNullOrEmpty(path))
                filePath = Path.Combine(path, filePath);
            if (File.Exists(filePath)) {
                using (Stream stream = File.OpenRead(filePath)) {
                    this.LoadFrom(stream);
                }
            }
        }
        public Fishes(Stream stream) {
            this.LoadFrom(stream);
        }
        void LoadFrom(Stream stream) {
            TextReader input = new StreamReader(stream);
            string line;
            int id = 0;
            while ((line = input.ReadLine()) != null) {
                string[] items = line.Split('|');
                if (items.Length == 4) {
                    ++id;
                    Fish fishItem = new Fish(items[0], items[1], items[2], items[3], id);
                    this.Add(fishItem);
                }
            }
            input.Close();
        }
    }
    public class Fish {
        private int id;
        private string category = "Undefined";
        private string commonName = "Undefined";
        private string speciesName = "Undefined";
        private string notes = "Undefined";

        [DisplayName("Fish Category")]
        public string Category {
            get { return category; }
            set { category = value; }
        }
        [DisplayName("Fish Common Name")]
        public string CommonName {
            get { return commonName; }
            set { commonName = value; }
        }
        [DisplayName("Fish Species Name")]
        public string SpeciesName {
            get { return speciesName; }
            set { speciesName = value; }
        }
        [DisplayName("Fish Notes")]
        public string Notes {
            get { return notes; }
            set { notes = value; }
        }
        [DisplayName("Fish ID")]
        public int ID {
            get { return id; }
            set { id = value; }
        }
        public Fish(string category, string commonName, string speciesName, string notes, int id) {
            this.category = category;
            this.commonName = commonName;
            this.speciesName = speciesName;
            this.notes = notes;
            this.id = id;
        }
    }
}
