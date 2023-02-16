using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPokedex
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            pokemonList = negocio.ListarPokemons();
            DGVpokemons.DataSource = pokemonList;
            PBpokemon.Load(pokemonList[0].URLimagen);
        }

        private void DGVpokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)DGVpokemons.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.URLimagen);

        }
        private void CargarImagen (String imagen)
        {
            try
            {
                PBpokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                PBpokemon.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }
    } 
}
