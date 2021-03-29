using System;
using System.Collections.Generic;
using System.Text;

namespace TPLecture.DBLib
{
    public class Livre
    {
        #region Attributs
		private int _Identifiant;
        private string _Titre;
		private string _Edition;
		private int _DateEdition;
		private DateTime _DateLecture;
		private int _Note;
		private string _Resume;
		private string _Commentaire;
		private string _ISBN;
		private int _NombresPages;
		#endregion

		#region Properties

		public string ISBN
		{
			get { return _ISBN; }
			set { _ISBN = value; }
		}

		public int NombresPages
		{
			get { return _NombresPages; }
			set { _NombresPages = value; }
		}

		public int Identifiant
		{
			get { return _Identifiant; }
			set { _Identifiant = value; }
		}

		public string Commentaire 
		{
			get { return _Commentaire; }
			set { _Commentaire = value; }
		}

		public string Resume
		{
			get { return _Resume; }
			set { _Resume = value; }
		}


		public int Note
		{
			get { return _Note; }
			set { _Note = value; }
		}




		public DateTime DateLecture
		{
			get { return _DateLecture; }
			set { _DateLecture = value; }
		}

		public int DateEdition
		{
			get { return  _DateEdition; }
			set {  _DateEdition = value; }
		}


		public string Edition 
		{
			get { return _Edition; }
			set { _Edition = value; }
		}

		public string Titre
		{
			get { return _Titre; }
			set { _Titre = value; }
		}
		#endregion
	}
}
