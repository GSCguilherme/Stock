﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoStock.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirProduto", ReplyAction="http://tempuri.org/IService1/inserirProdutoResponse")]
        void inserirProduto(Biblioteca.modelo.basicas.Produto bprod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirProduto", ReplyAction="http://tempuri.org/IService1/inserirProdutoResponse")]
        System.Threading.Tasks.Task inserirProdutoAsync(Biblioteca.modelo.basicas.Produto bprod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarProduto", ReplyAction="http://tempuri.org/IService1/alterarProdutoResponse")]
        void alterarProduto(Biblioteca.modelo.basicas.Produto bprod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarProduto", ReplyAction="http://tempuri.org/IService1/alterarProdutoResponse")]
        System.Threading.Tasks.Task alterarProdutoAsync(Biblioteca.modelo.basicas.Produto bprod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletarProduto", ReplyAction="http://tempuri.org/IService1/deletarProdutoResponse")]
        void deletarProduto(Biblioteca.modelo.basicas.Produto bprod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletarProduto", ReplyAction="http://tempuri.org/IService1/deletarProdutoResponse")]
        System.Threading.Tasks.Task deletarProdutoAsync(Biblioteca.modelo.basicas.Produto bprod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarProduto", ReplyAction="http://tempuri.org/IService1/listarProdutoResponse")]
        Biblioteca.modelo.basicas.Produto[] listarProduto(Biblioteca.modelo.basicas.Produto bprod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarProduto", ReplyAction="http://tempuri.org/IService1/listarProdutoResponse")]
        System.Threading.Tasks.Task<Biblioteca.modelo.basicas.Produto[]> listarProdutoAsync(Biblioteca.modelo.basicas.Produto bprod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirMovimentacao", ReplyAction="http://tempuri.org/IService1/inserirMovimentacaoResponse")]
        void inserirMovimentacao(Biblioteca.modelo.basicas.Movimentacao bmov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirMovimentacao", ReplyAction="http://tempuri.org/IService1/inserirMovimentacaoResponse")]
        System.Threading.Tasks.Task inserirMovimentacaoAsync(Biblioteca.modelo.basicas.Movimentacao bmov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarMovimentacao", ReplyAction="http://tempuri.org/IService1/alterarMovimentacaoResponse")]
        void alterarMovimentacao(Biblioteca.modelo.basicas.Movimentacao bmov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarMovimentacao", ReplyAction="http://tempuri.org/IService1/alterarMovimentacaoResponse")]
        System.Threading.Tasks.Task alterarMovimentacaoAsync(Biblioteca.modelo.basicas.Movimentacao bmov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletarMovimentacao", ReplyAction="http://tempuri.org/IService1/deletarMovimentacaoResponse")]
        void deletarMovimentacao(Biblioteca.modelo.basicas.Movimentacao bmov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletarMovimentacao", ReplyAction="http://tempuri.org/IService1/deletarMovimentacaoResponse")]
        System.Threading.Tasks.Task deletarMovimentacaoAsync(Biblioteca.modelo.basicas.Movimentacao bmov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarMovimentacao", ReplyAction="http://tempuri.org/IService1/listarMovimentacaoResponse")]
        Biblioteca.modelo.basicas.Movimentacao[] listarMovimentacao(Biblioteca.modelo.basicas.Movimentacao bmov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarMovimentacao", ReplyAction="http://tempuri.org/IService1/listarMovimentacaoResponse")]
        System.Threading.Tasks.Task<Biblioteca.modelo.basicas.Movimentacao[]> listarMovimentacaoAsync(Biblioteca.modelo.basicas.Movimentacao bmov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getMax", ReplyAction="http://tempuri.org/IService1/getMaxResponse")]
        int getMax();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getMax", ReplyAction="http://tempuri.org/IService1/getMaxResponse")]
        System.Threading.Tasks.Task<int> getMaxAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirProd_Mov", ReplyAction="http://tempuri.org/IService1/inserirProd_MovResponse")]
        void inserirProd_Mov(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirProd_Mov", ReplyAction="http://tempuri.org/IService1/inserirProd_MovResponse")]
        System.Threading.Tasks.Task inserirProd_MovAsync(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarProd_Mov", ReplyAction="http://tempuri.org/IService1/alterarProd_MovResponse")]
        void alterarProd_Mov(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarProd_Mov", ReplyAction="http://tempuri.org/IService1/alterarProd_MovResponse")]
        System.Threading.Tasks.Task alterarProd_MovAsync(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletarProd_Mov", ReplyAction="http://tempuri.org/IService1/deletarProd_MovResponse")]
        void deletarProd_Mov(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletarProd_Mov", ReplyAction="http://tempuri.org/IService1/deletarProd_MovResponse")]
        System.Threading.Tasks.Task deletarProd_MovAsync(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarProd_Mov", ReplyAction="http://tempuri.org/IService1/listarProd_MovResponse")]
        Biblioteca.modelo.basicas.ProdutoMovimentacao[] listarProd_Mov(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarProd_Mov", ReplyAction="http://tempuri.org/IService1/listarProd_MovResponse")]
        System.Threading.Tasks.Task<Biblioteca.modelo.basicas.ProdutoMovimentacao[]> listarProd_MovAsync(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirGerente", ReplyAction="http://tempuri.org/IService1/inserirGerenteResponse")]
        void inserirGerente(Biblioteca.modelo.basicas.Gerente bgeren);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirGerente", ReplyAction="http://tempuri.org/IService1/inserirGerenteResponse")]
        System.Threading.Tasks.Task inserirGerenteAsync(Biblioteca.modelo.basicas.Gerente bgeren);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarGerente", ReplyAction="http://tempuri.org/IService1/alterarGerenteResponse")]
        void alterarGerente(Biblioteca.modelo.basicas.Gerente bgeren);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarGerente", ReplyAction="http://tempuri.org/IService1/alterarGerenteResponse")]
        System.Threading.Tasks.Task alterarGerenteAsync(Biblioteca.modelo.basicas.Gerente bgeren);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletarGerente", ReplyAction="http://tempuri.org/IService1/deletarGerenteResponse")]
        void deletarGerente(Biblioteca.modelo.basicas.Gerente bgeren);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletarGerente", ReplyAction="http://tempuri.org/IService1/deletarGerenteResponse")]
        System.Threading.Tasks.Task deletarGerenteAsync(Biblioteca.modelo.basicas.Gerente bgeren);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarGerente", ReplyAction="http://tempuri.org/IService1/listarGerenteResponse")]
        Biblioteca.modelo.basicas.Gerente[] listarGerente(Biblioteca.modelo.basicas.Gerente bgeren);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarGerente", ReplyAction="http://tempuri.org/IService1/listarGerenteResponse")]
        System.Threading.Tasks.Task<Biblioteca.modelo.basicas.Gerente[]> listarGerenteAsync(Biblioteca.modelo.basicas.Gerente bgeren);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ProjetoStock.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ProjetoStock.ServiceReference1.IService1>, ProjetoStock.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void inserirProduto(Biblioteca.modelo.basicas.Produto bprod) {
            base.Channel.inserirProduto(bprod);
        }
        
        public System.Threading.Tasks.Task inserirProdutoAsync(Biblioteca.modelo.basicas.Produto bprod) {
            return base.Channel.inserirProdutoAsync(bprod);
        }
        
        public void alterarProduto(Biblioteca.modelo.basicas.Produto bprod) {
            base.Channel.alterarProduto(bprod);
        }
        
        public System.Threading.Tasks.Task alterarProdutoAsync(Biblioteca.modelo.basicas.Produto bprod) {
            return base.Channel.alterarProdutoAsync(bprod);
        }
        
        public void deletarProduto(Biblioteca.modelo.basicas.Produto bprod) {
            base.Channel.deletarProduto(bprod);
        }
        
        public System.Threading.Tasks.Task deletarProdutoAsync(Biblioteca.modelo.basicas.Produto bprod) {
            return base.Channel.deletarProdutoAsync(bprod);
        }
        
        public Biblioteca.modelo.basicas.Produto[] listarProduto(Biblioteca.modelo.basicas.Produto bprod) {
            return base.Channel.listarProduto(bprod);
        }
        
        public System.Threading.Tasks.Task<Biblioteca.modelo.basicas.Produto[]> listarProdutoAsync(Biblioteca.modelo.basicas.Produto bprod) {
            return base.Channel.listarProdutoAsync(bprod);
        }
        
        public void inserirMovimentacao(Biblioteca.modelo.basicas.Movimentacao bmov) {
            base.Channel.inserirMovimentacao(bmov);
        }
        
        public System.Threading.Tasks.Task inserirMovimentacaoAsync(Biblioteca.modelo.basicas.Movimentacao bmov) {
            return base.Channel.inserirMovimentacaoAsync(bmov);
        }
        
        public void alterarMovimentacao(Biblioteca.modelo.basicas.Movimentacao bmov) {
            base.Channel.alterarMovimentacao(bmov);
        }
        
        public System.Threading.Tasks.Task alterarMovimentacaoAsync(Biblioteca.modelo.basicas.Movimentacao bmov) {
            return base.Channel.alterarMovimentacaoAsync(bmov);
        }
        
        public void deletarMovimentacao(Biblioteca.modelo.basicas.Movimentacao bmov) {
            base.Channel.deletarMovimentacao(bmov);
        }
        
        public System.Threading.Tasks.Task deletarMovimentacaoAsync(Biblioteca.modelo.basicas.Movimentacao bmov) {
            return base.Channel.deletarMovimentacaoAsync(bmov);
        }
        
        public Biblioteca.modelo.basicas.Movimentacao[] listarMovimentacao(Biblioteca.modelo.basicas.Movimentacao bmov) {
            return base.Channel.listarMovimentacao(bmov);
        }
        
        public System.Threading.Tasks.Task<Biblioteca.modelo.basicas.Movimentacao[]> listarMovimentacaoAsync(Biblioteca.modelo.basicas.Movimentacao bmov) {
            return base.Channel.listarMovimentacaoAsync(bmov);
        }
        
        public int getMax() {
            return base.Channel.getMax();
        }
        
        public System.Threading.Tasks.Task<int> getMaxAsync() {
            return base.Channel.getMaxAsync();
        }
        
        public void inserirProd_Mov(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov) {
            base.Channel.inserirProd_Mov(prod_mov);
        }
        
        public System.Threading.Tasks.Task inserirProd_MovAsync(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov) {
            return base.Channel.inserirProd_MovAsync(prod_mov);
        }
        
        public void alterarProd_Mov(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov) {
            base.Channel.alterarProd_Mov(prod_mov);
        }
        
        public System.Threading.Tasks.Task alterarProd_MovAsync(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov) {
            return base.Channel.alterarProd_MovAsync(prod_mov);
        }
        
        public void deletarProd_Mov(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov) {
            base.Channel.deletarProd_Mov(prod_mov);
        }
        
        public System.Threading.Tasks.Task deletarProd_MovAsync(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov) {
            return base.Channel.deletarProd_MovAsync(prod_mov);
        }
        
        public Biblioteca.modelo.basicas.ProdutoMovimentacao[] listarProd_Mov(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov) {
            return base.Channel.listarProd_Mov(prod_mov);
        }
        
        public System.Threading.Tasks.Task<Biblioteca.modelo.basicas.ProdutoMovimentacao[]> listarProd_MovAsync(Biblioteca.modelo.basicas.ProdutoMovimentacao prod_mov) {
            return base.Channel.listarProd_MovAsync(prod_mov);
        }
        
        public void inserirGerente(Biblioteca.modelo.basicas.Gerente bgeren) {
            base.Channel.inserirGerente(bgeren);
        }
        
        public System.Threading.Tasks.Task inserirGerenteAsync(Biblioteca.modelo.basicas.Gerente bgeren) {
            return base.Channel.inserirGerenteAsync(bgeren);
        }
        
        public void alterarGerente(Biblioteca.modelo.basicas.Gerente bgeren) {
            base.Channel.alterarGerente(bgeren);
        }
        
        public System.Threading.Tasks.Task alterarGerenteAsync(Biblioteca.modelo.basicas.Gerente bgeren) {
            return base.Channel.alterarGerenteAsync(bgeren);
        }
        
        public void deletarGerente(Biblioteca.modelo.basicas.Gerente bgeren) {
            base.Channel.deletarGerente(bgeren);
        }
        
        public System.Threading.Tasks.Task deletarGerenteAsync(Biblioteca.modelo.basicas.Gerente bgeren) {
            return base.Channel.deletarGerenteAsync(bgeren);
        }
        
        public Biblioteca.modelo.basicas.Gerente[] listarGerente(Biblioteca.modelo.basicas.Gerente bgeren) {
            return base.Channel.listarGerente(bgeren);
        }
        
        public System.Threading.Tasks.Task<Biblioteca.modelo.basicas.Gerente[]> listarGerenteAsync(Biblioteca.modelo.basicas.Gerente bgeren) {
            return base.Channel.listarGerenteAsync(bgeren);
        }
    }
}
