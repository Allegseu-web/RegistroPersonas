using System;
using System.Collections.Generic;
using System.Text;
using RegistroPersonas.Entidades;
using RegistroPersonas.DAL;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace RegistroPersonas.BLL
{
    class PersonasBLL
    {
        public static bool Guardar(Personas Persona)
        {
            if (!Existe(Persona.PersonaID))
            {
                return Insertar(Persona);
            }
            else
            {
                return Modificar(Persona);
            }
        }

        public static bool Insertar(Personas Persona)
        {
            Contexto contexto = new Contexto();

            bool esOk = false;

            try
            {
                if(contexto.Personas.Add(Persona) != null) { esOk = contexto.SaveChanges() > 0; }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return esOk;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();

            bool esOk = false;

            try
            {
                esOk = contexto.Personas.Any(e => e.PersonaID == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return esOk;
        }

        public static bool Modificar(Personas Persona)
        {
            Contexto contexto = new Contexto();

            bool esOk = false;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM PersonasDetalle where PersonaId={Persona.PersonaID}");
                foreach(var item in Persona.Detalles)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }
                contexto.Entry(Persona).State = EntityState.Modified;
                esOk = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return esOk;
        }

        public static Personas Buscar(int Id)
        {
            Contexto contexto = new Contexto();

            Personas Persona = new Personas();

            try
            {
                Persona = contexto.Personas.Include(x => x.Detalles).Where(x => x.PersonaID == Id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Persona;
        }

        public static bool Eliminar(int Id)
        {
            Contexto contexto = new Contexto();

            bool esOk = false;

            try
            {
                var Persona = contexto.Personas.Find(Id);
                if(Persona != null)
                {
                    contexto.Personas.Remove(Persona);
                    esOk = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return esOk;
        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> criterio)
        {
            Contexto contexto = new Contexto();

            List<Personas> Lista = new List<Personas>();

            try
            {
                Lista = contexto.Personas.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}
