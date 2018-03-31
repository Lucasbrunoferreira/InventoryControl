﻿using System;
using System.Collections.Generic;
using System.Text;
using BancoDeDados.ObjetoDeAcesso;
using DAL;
using DAL.Models;
using DAL.ModelView;

namespace App.BLL
{
    public class ProviderBll
    {

        public void Inserir(ProviderModelView providerModelView)
        {

            var provider = new Provider();

            provider = PreparaProvider(providerModelView, provider);

            var providerDao = new ProviderDao();
            providerDao.Inserir(provider);

        }

        public Provider ObterPorId(int id)
        {

            var providerDao = new ProviderDao();
            return providerDao.obeterPorId(id);

        }

        public void Delete(int id)
        {

            var providerDao = new ProviderDao();
            providerDao.Deletar(id);

        }

        public void Atualizar(int id, ProviderModelView providerModelView)
        {

            var providerDao = new ProviderDao();
            var provider = providerDao.obeterPorId(id);

            var providerAt = PreparaProvider(providerModelView, provider);

            providerAt.IdProvider = id;
            providerDao.Atualizar(providerAt);
        }

        public List<Provider> ObterTodos()
        {

            var providerDao = new ProviderDao();
            return providerDao.ObterTodos();

        }

        public Provider PreparaProvider(ProviderModelView providerModelView, Provider provider)
        {

            var provider1 = new Provider();
            var cnpj = new ValidarCNPJ();

            if (providerModelView.Cnpj.Trim().Length != 0 && providerModelView.Cidade.Trim().Length != 0 && 
                providerModelView.Responsavel.Trim().Length != 0
                && providerModelView.Telefone.Trim().Length != 0 && providerModelView.Email.Trim().Length != 0 &&
                cnpj.IsCnpj(providerModelView.Cnpj) != false)
            {

                provider1.Cnpj = providerModelView.Cnpj;
                provider1.Cidade = providerModelView.Cidade;
                provider1.Responsavel = providerModelView.Responsavel;
                provider1.Telefone = providerModelView.Telefone;
                provider1.Email = providerModelView.Email;       

            }

            return provider1;

        }

    }
}
