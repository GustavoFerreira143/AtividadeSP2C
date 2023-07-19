 namespace Atividade{
class Pessoa_Juridica : Clientes{
      
        public string Cnpj{get;set;}
        public string Ie{get;set;}
        public override void Pagar_imposto(float v){
              this.valor = v;
        this.valor_imposto=this.valor *20/100;
        this.total=this.valor+this.valor_imposto;
              }
    }}