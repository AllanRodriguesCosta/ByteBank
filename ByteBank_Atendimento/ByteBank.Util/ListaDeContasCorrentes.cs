﻿using ByteBank.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Atendimento.ByteBank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao=0;

        public ListaDeContasCorrentes(int tamanhoInicial=5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VereficarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VereficarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length>= tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }

        public void Remover (ContaCorrente conta)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if (contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for(int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void ExibeLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($"Indice [{i}] = " + 
                        $"Conta: {conta.Conta} - " +  
                        $"N° da Agência: {conta.Numero_Agencia}");
                }
            }
        }

        public ContaCorrente RecuperarContaNoIndice(int indice)
        {
            if (indice<0 || indice>=_proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];

        }

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }

        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
            

        }
    }
}
