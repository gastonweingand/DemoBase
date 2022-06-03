using Services.DAL.Contracts;
using Services.DAL.Implementations.Adapter;
using Services.DAL.Tools;
using Services.DomainModel.Security.Composite;
using Services.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations
{

    internal sealed class FamiliaRepository : IGenericRepository<Familia>
    {

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
            get => "Familia_Select";
        }

        private string SelectAllStatement
        {
            get => "Familia_SelectAll";
        }

        #endregion

        #region Singleton
        private readonly static FamiliaRepository _instance = new FamiliaRepository();

        public static FamiliaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaRepository()
        {
            //Implement here the initialization code
        }
        #endregion
        public void Add(Familia obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Familia> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Familia SelectOne(Guid id)
        {
            Familia patenteGet = null;

            try
            {
                using (var reader = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.StoredProcedure,
                                                new SqlParameter[] { new SqlParameter("@IdFamilia", id) }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        patenteGet = FamiliaAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
            }

            return patenteGet;
        }

        public void Update(Familia obj)
        {
            throw new NotImplementedException();
        }
    }

}
