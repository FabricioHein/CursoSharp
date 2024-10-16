﻿using System;
using System.Collections.Generic;
using CursoCSharp;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using System.Collections;

namespace CursoSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                     // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                  // Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar},
                { "Construtores - Classes e Métodos", Construtores.Executar},
                { "Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Params - Classes e Métodos", Params.Executar},
                { "Params Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                { "Getters e Setters - Classes e Métodos", GetSet.Executar},
                { "Readonly - Classes e Métodos", Readonly.Executar},
                { "Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Structs - Classes e Métodos", ExemploStruct.Executar},

                //Coleções
                { "Array - Coleções", ArrayColecao.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "Array List - Coleções", ColecoesArrayList.Executar },
                { "Array SET - Coleções", ColecoesSet.Executar },
                { "Array Queue - Coleções", ColecoesQueue.Executar },
                { "Igualdade - Coleções", Igualdade.Executar },
                { "Stacks - Coleções", ColecoesStack.Executar },
                { "Dicionários - Coleções", ColecoesDictionary.Executar },



            });

            central.SelecionarEExecutar();
        }
    }
}