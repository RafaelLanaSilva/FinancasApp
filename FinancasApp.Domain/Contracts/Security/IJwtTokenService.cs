using FinancasApp.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Contracts.Security
{
    /// <summary>
    /// Interface para definir os métodos de infraestrutura de autenticação do projeto através do JWT
    /// </summary>
    public interface IJwtTokenService
    {
        //método para gerar token JWT do usuário
        string GetJwtToken(Usuario usuario);
    }
}
