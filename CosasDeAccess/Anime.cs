using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosasDeAccess
{
    class Anime
    {
		private String Nombre;
		private String Genero;
		private String Ruta;
		private String Imagen;
		private int Temporadas;
		private int Capitulos;
		public Anime(String nombre, String genero, String ruta, String imagen, int temporadas, int capitulos)
		{
			Nombre = nombre;
			Genero = genero;
			Ruta = ruta;
			Imagen = imagen;
			Temporadas = temporadas;
			Capitulos = capitulos;
		}
		public String getNombre()
		{
			return Nombre;
		}
		public void setNombre(String nombre)
		{
			Nombre = nombre;
		}
		public String getGenero()
		{
			return Genero;
		}
		public void setGenero(String genero)
		{
			Genero = genero;
		}
		public String getRuta()
		{
			return Ruta;
		}
		public void setRuta(String ruta)
		{
			Ruta = ruta;
		}
		public String getImagen()
		{
			return Imagen;
		}
		public void setImagen(String imagen)
		{
			Imagen = imagen;
		}
		public int getTemporadas()
		{
			return Temporadas;
		}
		public void setTemporadas(int temporadas)
		{
			Temporadas = temporadas;
		}
		public int getCapitulos()
		{
			return Capitulos;
		}
		public void setCapitulos(int capitulos)
		{
			Capitulos = capitulos;
		}
	}
}
