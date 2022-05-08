using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosasDeAccess
{
    class Pelicula
    {
		private String Id;
		private String Nombre;
		private int Duracion;
		private String Ruta;
		private String Anime;
		private int Posicion;

		public Pelicula(String id, String nombre, int duracion, String ruta, String anime, int posicion)
		{
			Id = id;
			Nombre = nombre;
			Duracion = duracion;
			Ruta = ruta;
			Anime = anime;
			Posicion = posicion;
		}
		public String getId()
		{
			return Id;
		}
		public void setId(String id)
		{
			Id = id;
		}
		public String getNombre()
		{
			return Nombre;
		}
		public void setNombre(String nombre)
		{
			Nombre = nombre;
		}
		public int getDuracion()
		{
			return Duracion;
		}
		public void setDuracion(int duracion)
		{
			Duracion = duracion;
		}
		public String getRuta()
		{
			return Ruta;
		}
		public void setRuta(String ruta)
		{
			Ruta = ruta;
		}
		public String getAnime()
		{
			return Anime;
		}
		public void setAnime(String anime)
		{
			Anime = anime;
		}
		public int getPosicion()
		{
			return Posicion;
		}
		public void setPosicion(int posicion)
		{
			Posicion = posicion;
		}
	}
}
