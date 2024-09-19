using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    static class ConexaoBanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "dbFuncionarios";
        private const string usuario = "root";
        private const string senha = "";

        static public string bancoServidor = $"server = {servidor}; user Id = {usuario}; database = {bancoDados}; password = {senha}"; 
         
    }
}
