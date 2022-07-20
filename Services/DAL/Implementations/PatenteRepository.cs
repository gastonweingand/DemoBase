using Services.DAL.Contracts;
using Services.DomainModel.Security.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.DAL.Tools;
using System.Data.SqlClient;
using Services.Services.Extensions;
using Services.DAL.Implementations.Adapter;

namespace Services.DAL.Implementations
{

    internal sealed class PatenteRepository : IGenericRepository<Patente>
    {
        #region Singleton
        private readonly static PatenteRepository _instance = new PatenteRepository();

        public static PatenteRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private PatenteRepository()
        {
            //Implement here the initialization code
        }
        #endregion


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[] () VALUES ()";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[] SET () WHERE  = @";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[] WHERE  = @";
        }

        private string SelectOneStatement
        {
            get => "Patente_Select";
        }

        private string SelectAllStatement
        {
            get => "Patente_SelectAll";
        }
        #endregion

        public void Add(Patente obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patente> SelectAll()
        {   
            List<Patente> patentes = new List<Patente>();
            Patente patenteGet = null;

            try
            {
                using (var reader = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.StoredProcedure))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        patenteGet = PatenteAdapter.Current.Adapt(values);
                        patentes.Add(patenteGet);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
            }

            return patentes;
        }

        public Patente SelectOne(Guid id)
        {
            Patente patenteGet = null;

            try
            {
                using (var reader = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.StoredProcedure,
                                                new SqlParameter[] { new SqlParameter("@IdPatente", id) }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        patenteGet = PatenteAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
            }

            return patenteGet;
        }

        public void Update(Patente obj)
        {
            throw new NotImplementedException();
        }
    }
}
