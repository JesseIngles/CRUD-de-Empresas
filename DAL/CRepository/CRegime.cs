using CrudEmpresas.Controllers;
using CrudEmpresas.DAL.Database;
using CrudEmpresas.DAL.IRepository;
using CrudEmpresas.DTO;
using CrudEmpresas.Entities;
using CrudEmpresas.Services;
using FuzzySharp;

namespace CrudEmpresas.DAL.CRepository
{
    public class CRegime : IRegime
    {
        private readonly MyDbContext _db;
        public CRegime(MyDbContext context)
        {
            _db = context;
        }

<<<<<<< HEAD
        public async Task<DTO_Resposta> AtualizarRegime(DTO_Regime regime, int id)
        {
            DTO_Resposta resposta = new DTO_Resposta();
            try
            {
                var RegimeExistente = _db.TbRegime.First(a => a.Id == id);
                if (RegimeExistente != null)
                {
                    RegimeExistente.Nome = regime.Nome;
                    await _db.SaveChangesAsync();
                    resposta.mensagem = "Sucesso";
                    return resposta;
                }
                resposta.mensagem = "Não existe";
            }
            catch (System.Exception ex)
            {
                resposta.mensagem = ex.ToString();
            }
            return resposta;
        }

        public async Task<DTO_Resposta> CadastrarRegime(DTO_Regime regime)
        {
            DTO_Resposta resposta = new DTO_Resposta();
            try
            {
                var NovoRegime = new regime
                {
                    Nome = regime.Nome,
                };
                if (NovoRegime == null)
                {
                    resposta.mensagem = "Dados inválidos";
                    return resposta;
                }
            
                
        
        }

    
                
            
        }

    }

}
=======
        public Task<DTO_Resposta> CadastrarRegime()
        {
            throw new NotImplementedException();
        }
    }
}

       
                
      


                
                
           
         
    

                     
                         
                   
                                                                           
  


            
                      

       
>>>>>>> 5ef677ed0ccce53a5d5592b0e62a6828c049ad25
