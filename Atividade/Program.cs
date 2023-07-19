// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Atividade;

using System;
namespace Atividade{
class Program {
         static void Main(string[] args){
             Clientes c=new Clientes();
             Pessoa_Juridica j=new Pessoa_Juridica();
             Pessoa_Fisica p=new Pessoa_Fisica();
             string Caminhodados=@"C:\Users\Intel\Senai\Dados.txt";
             var stream = new StreamWriter(Caminhodados);
             float val_pag;
             Console.WriteLine("Informar Nome");
             string var_nome=Console.ReadLine();
             c.nome=var_nome;
             Console.WriteLine("Informar Endereço");
             string var_endereço=Console.ReadLine();
             c.endereco=var_endereço;
             Console.WriteLine("Pessoa Fisica(f) ou Juridica (j)");
             string var_escolha=Console.ReadLine();
             if (var_escolha=="f")
             {
                Console.WriteLine("Digite sua data de Nascimento");
                string var_Nascimento=Console.ReadLine();
                p.DataNascimento=var_Nascimento;
                Console.WriteLine("Digite seu CPF");
                string var_Cpf=Console.ReadLine();
                p.Cpf=var_Cpf;
                Console.WriteLine("Digite seu RG");
                string var_Rg=Console.ReadLine();
                p.Rg=var_Rg;
                Console.WriteLine("Valor a ser aplicado");
                val_pag=float.Parse(Console.ReadLine());
                Console.WriteLine("O valor aplicado será calculado com uma margem de imposto de 10%");
                
                c.Pagar_imposto(val_pag);
                Console.WriteLine("--------------Pessoa Fisica-----------------");
                Console.WriteLine("Nome ..................:"+c.nome);
                Console.WriteLine("Data de Nascimento .................:"+p.DataNascimento);
                Console.WriteLine("Endereço ................:"+ c.endereco);
                Console.WriteLine("CPF ......................:"+ p.Cpf);
                Console.WriteLine("Rg .......................:"+p.Rg);
                Console.WriteLine("Valor de Compra ...............:"+c.valor.ToString("C"));
                Console.WriteLine("Imposto ......................:"+c.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar :"+c.total.ToString("C"));
                
                stream.WriteLine("--------------Pessoa Fisica-----------------");
                stream.WriteLine("Nome ..................:"+c.nome);
                stream.WriteLine("Data de Nascimento .................:"+p.DataNascimento);
                stream.WriteLine("Endereço ................:"+ c.endereco);
                stream.WriteLine("CPF ......................:"+ p.Cpf);
                stream.WriteLine("Rg .......................:"+p.Rg);
                stream.WriteLine("Valor de Compra ...............:"+c.valor.ToString("C"));
                stream.WriteLine("Imposto ......................:"+c.valor_imposto.ToString("C"));
                stream.WriteLine("Total a Pagar :"+c.total.ToString("C"));
                stream.WriteLine("-------------------O valor aplicado foi calculado com uma margem de imposto de 10%--------------------");
                stream.Close();
             }
             else if (var_escolha=="j")
             { 
                Console.WriteLine("Digite seu Cnpj");
                string var_Cnpj=Console.ReadLine();
                j.Cnpj=var_Cnpj;
                Console.WriteLine("Digite seu Ie ");
                string var_Ie=Console.ReadLine();
                j.Ie=var_Ie;
                Console.WriteLine("Valor a ser aplicado");
                val_pag=float.Parse(Console.ReadLine());
                
                Console.WriteLine("O valor aplicado será calculado com uma margem de imposto de 20%");
                j.Pagar_imposto(val_pag);
                 Console.WriteLine("-------------------Pessoa Juridica ------------------");
                 Console.WriteLine("Nome ..................:"+c.nome);
                 Console.WriteLine("Endereço ................:"+ c.endereco);
                 Console.WriteLine("CNPJ .....................:"+j.Cnpj);
                 Console.WriteLine("IE .........................:"+j.Ie);
                 Console.WriteLine("Valor de Compra ..................:"+c.valor.ToString("C"));
                 Console.WriteLine("Imposto Aplicado .......................:"+j.valor_imposto.ToString("C"));
                 Console.WriteLine("Total a pagar ................:"+ j.total.ToString("C"));

                 stream.WriteLine("-------------------Pessoa Juridica ------------------");
                 stream.WriteLine("Nome ..................:"+c.nome);
                 stream.WriteLine("Endereço ................:"+ c.endereco);
                 stream.WriteLine("CNPJ .....................:"+j.Cnpj);
                 stream.WriteLine("IE .........................:"+j.Ie);
                 stream.WriteLine("Valor de Compra ..................:"+c.valor.ToString("C"));
                 stream.WriteLine("Imposto Aplicado .......................:"+j.valor_imposto.ToString("C"));
                 stream.WriteLine("Total a pagar ................:"+ j.total.ToString("C"));
                 stream.WriteLine("-----------------O valor aplicado foi calculado com uma margem de imposto de 20%------------");
                 stream.Close();
             }
             else{
                Console.WriteLine("Nomeclatura Invalida");

                stream.WriteLine("Nomeclatura Invalida");
                stream.Close();
             }
        }
    }}

