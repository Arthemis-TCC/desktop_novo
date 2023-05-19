﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace tcc1
{
    class svn_engenhiro : conexao
    {
        private string cidade;
        private string status_svn;
        private string data_svn;
        private string codigo;
        private string check;


        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getCidade()
        {
            return this.cidade;
        }

        public void setStatus_svn(string status_svn)
        {
            this.status_svn = status_svn;
        }

        public string getStatus_svn()
        {
            return this.status_svn;
        }

        public void setData_svn(string data_svn)
        {
             this.data_svn = data_svn;
        }

        public string getData_svn()
        {
            return this.data_svn;
        }

        
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string getCodigo()
        {
            return this.codigo;
        }

        public void setCheck(string check)
        {
            this.check = check;
        }

        public string getCheck()
        {
            return this.check;
        }




        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from svn_engenheiro";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void inserir()
        {
            string query = "insert into svn_engenheiro (cidade, status_svn, data_svn)VALUES('" + getCidade() + "', '" + getStatus_svn() + "', '" + getData_svn() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

       
        public void alterar()
        {
            // string query = "UPDATE svn_engenheiro SET cidade = '" + getCidade() + "', status_svn= '" + getStatus_svn() + "', data_svn= '" + getData_svn() +"', check_svn = '" + getCheck() + "'Where codigo = '" + getCodigo() + "'";
             string query = "UPDATE svn_engenheiro SET check_svn = 1 Where codigo=  1";
            if (this.abrirconexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
      



    }
}
