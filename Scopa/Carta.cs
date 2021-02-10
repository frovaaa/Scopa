﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scopa
{
    public partial class Carta : System.Windows.Forms.PictureBox
    {
        //private int posInVet, nImmagine;
        //private bool coperta = true, clickable = true;
        //private string nomeCopertina = "Back", posImmaginiDefault = "../../Img/", estensione = ".png";
        private int nCarta = 0, nSeme = 0;          //Cuori = 1, Quadri = 2, Fiori = 3, Picche = 4

        public Carta(int nCartaP, int nSemeP/*int xP, int yP, int larghezza, int altezza, int nImmagine, int posInVet*/)
        {
            nCarta = nCartaP;
            nSeme = nSemeP;

            #region Vecchio
            //this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;            //Imposto il bordo incavato
            //this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;   //Imposto lo stretch dell'immagine
            //this.ImageLocation = posImmaginiDefault + nomeCopertina + estensione;                                      //Imposto l'immagine come retro carta
            //this.Location = new System.Drawing.Point(xP, yP);                       //Imposto la posizione nel form della PictreBox
            //this.Size = new System.Drawing.Size(larghezza, altezza);                //Imposto le dimensioni
            //this.Tag = nImmagine;                                                   //Inserisco nel tag il numero identificativo dell'immagine
            //this.posInVet = posInVet;                                               //Inserisco la posizione nel vettore nella sua variabile
            //this.nImmagine = nImmagine;
            #endregion
        }

        /*public void Gira()
        {
            //Funzione per "girare" la tessera cambiando la ImageLocation
            this.ImageLocation = coperta ? posImmaginiDefault + nImmagine + estensione : posImmaginiDefault + nomeCopertina + estensione;
            coperta = !coperta;
        }*/
        //public int PosInVet { get { return posInVet; } }
        //public bool Cliccabile { get { return clickable; } set { clickable = value; } }
        /*public int NImmagine
        {
            get { return nImmagine; }
            set
            {
                nImmagine = value;
                this.ImageLocation = (clickable) ? posImmaginiDefault + nomeCopertina + estensione : posImmaginiDefault + nImmagine + estensione;   //Aggiorno pure la ImageLocation
                this.Tag = nImmagine;   //Aggiorno il tag
            }
        }*/
        /*public string PosImmaginiDefault
        {
            get { return posImmaginiDefault; }
            set
            {
                posImmaginiDefault = value;
                //Se le carte sono già state girate devo refresharle per cambiare il tema
                if (clickable == false) this.ImageLocation = posImmaginiDefault + nImmagine + estensione;
            }
        }*/
        public int NCarta { get { return nCarta; } set { nCarta = value; } }
        public int NSeme { get { return nSeme; } set { nSeme = value; } }
    }
}