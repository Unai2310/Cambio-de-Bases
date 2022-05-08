using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosasDeAccess
{
    class Temporada
    {
		private String Id;
		private String Nombre;
		private int Capitulos;
		private String Ruta;
		private String Op;
		private String Anime;
		private int Posicion;

		public Temporada(String id, String nombre, int capitulos, String ruta, String op, String anime, int posicion)
		{
			Id = id;
			Nombre = nombre;
			Capitulos = capitulos;
			Ruta = ruta;
			Op = op;
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
		public int getCapitulos()
		{
			return Capitulos;
		}
		public void setCapitulos(int capitulos)
		{
			Capitulos = capitulos;
		}
		public String getRuta()
		{
			return Ruta;
		}
		public void setRuta(String ruta)
		{
			Ruta = ruta;
		}
		public String getOp()
		{
			return Op;
		}
		public void setOp(String op)
		{
			Op = op;
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
