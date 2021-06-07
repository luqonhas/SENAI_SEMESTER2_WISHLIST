import {Link} from 'react-router-dom';
import { Component } from "react";
import "../../assets/css/style.css";
import logo from "../../assets/img/logo.svg";
import sair from "../../assets/img/sair.svg";
import ordenagem from "../../assets/img/ordenagem.svg";
import lixeira from "../../assets/img/lixeira.svg";
import coracaoff from "../../assets/img/coração-off.svg";
import fita from "../../assets/img/fita.svg";

function DataFormatada(){
    return new Intl.DateTimeFormat('pt-BR', {day: 'numeric', month: 'numeric', year: 'numeric'}).format()
}

// function AlterarTipo()

class Desejos extends Component {
  constructor(props) {
    super(props);
    this.state = {
      desejos : [],
      descricao : '',
      ordenado : false,

    };
  }

  listarDesejos = () => {
    fetch("http://localhost:5000/api/desejos")

    .then((resposta) => resposta.json())

    .then((data) => this.setState({ desejos : data }))

    .catch((erro) => console.log(erro));
  };

  

  cadastrarDesejos = (event) => {
      event.preventDefault();

      fetch('http://localhost:5000/api/desejos', {

        method: 'POST', 

        body: JSON.stringify({descricao : this.state.descricao, dataCriacao : new Date().toJSON()}),

        headers: {
            "Content-Type" : "application/json"
        }
        })

        .then(console.log('Desejo cadastrado!'))

        .catch(erro => console.log(erro))

        .then(this.listarDesejos)

        .then(this.limparCampos)
  }



  limparCampos = () => {
    this.setState({
        descricao : ''
    })
  }



  atualizaEstadoDescricao = async (event) => {
    //  NomeState     Valor do input
    await this.setState({descricao : event.target.value})
  };



  excluirDesejo = (desejo) => {

    fetch('http://localhost:5000/api/desejos/' + desejo.idDesejo, {
        method : 'DELETE'
    })

    .then(resposta => {
        if (resposta.status === 204 ) {
            console.log(
                'Desejo ' + desejo.idDesejo + ' deletado!'
            )
        }
    })

    
    .then(this.listarDesejos)

    .catch(erro => console.log(erro))
  }



  componentDidMount(){
    this.listarDesejos();
  }



  render() {
    return (
      <div>
        {/* HEADER */}
        <header className="menu-bg">
          <div className="menu">
            <div className="menu-logo">
              <Link to="/">
                <img src={logo} />
              </Link>
            </div>

            <nav className="menu-nav">
              <ul>
                <li>
                  <a>
                    Bem vindo(a)
                    <br />
                    <span>luqonhas</span>
                  </a>
                </li>
                <li>
                  <Link to="/desejos">Meus Desejos</Link>
                </li>
                <li>
                  <Link to="/">
                    <img src={sair} />
                  </Link>
                </li>
              </ul>
            </nav>
          </div>
        </header>

        {/* WISHLIST */}
        <section className="wishlist">

            {/* LISTAR */}
            <section className="listar-bg">
                <form className="listar">
                    <div className="listar-menu">
                        <button onClick={() => {this.setState({ordenado : !this.state.ordenado}); this.listarDesejos()}}><img src={ordenagem} /></button>
                        <h1>Listar Desejos</h1>
                    </div>

                    <div className="listar-lista-bg">
                        <div className="lista-form">

                            {/* <div className="desejos">
                                <div className="desejos-conteudo">
                                    <div className="desejos-data-bg">
                                        <div className="desejos-data">
                                            <p>Adicionado em:</p>
                                            <p>05/06/2021</p>
                                        </div>
                                        <div className="desejos-texto">
                                            <p>Lucas ipsum dolor sit amet qui-gon feeorin wroonian adi plagueis zann subterrel solo lars darth...</p>
                                        </div>
                                        <div className="desejos-btns">
                                            <button type="submit"><img src={lixeira} /></button>
                                            <button type="submit"><img src={coracaoff} /></button>
                                            <button type="submit">Editar</button>
                                        </div>
                                    </div>
                                    <div className="desejos-tipo-bg">
                                        <div className="desejos-tipo">
                                            <p>Favorito</p>
                                        </div>
                                    </div>
                                </div>
                            </div> */}

                            {
                              this.state.ordenado && this.state.desejos.sort((a, b) => b.idDesejo - a.idDesejo),

                              this.state.desejos.map((desejo) => {
                                  return(
                                      <div className="desejos">
                                          <div className="desejos-conteudo" key={desejo.idDesejo}>
                                              <div className="desejos-data-bg">
                                                  <div className="desejos-data">
                                                      <p>Adicionado em:</p>
                                                      <p>{new Date(desejo.dataCriacao).toLocaleDateString()}</p>
                                                  </div>
                                                  <div className="desejos-texto">
                                                      <p>{desejo.descricao}</p>
                                                  </div>
                                                  <div className="desejos-btns">
                                                      <button onClick={() => this.excluirDesejo(desejo)}><img src={lixeira} /></button>
                                                      <button type="submit"><img src={coracaoff} /></button>
                                                      <button type="submit">Editar</button>
                                                  </div>
                                              </div>
                                              <div className="desejos-tipo-bg">
                                                  <div className="desejos-tipo">
                                                      <p>Favorito</p>
                                                  </div>
                                              </div>
                                          </div>
                                      </div>
                                    )
                                })
                            }

                        </div>
                    </div>
                </form>
            </section>

            {/* FITA NO MEIO */}
            <div className="fitinha"><img src={fita}></img></div>

            {/* CADASTRAR */}
            <section className="cadastrar-bg">
                <form className="cadastrar" onSubmit={this.cadastrarDesejos}>
                    <div className="cadastrar-menu">
                        <h1>Cadastrar Desejos</h1>
                    </div>
                    
                    <div className="cadastrar-cadastro-bg">
                        <div className="cadastro-form">
                            <textarea className="textarea" value={this.state.descricao} onChange={this.atualizaEstadoDescricao} required maxlength="126" type="text" name="desejo" id="desejo-textarea" cols="2" rows="5" placeholder="Descrição do desejo..."></textarea>
                            <button type="submit" disabled={this.state.descricao === '' ? 'none' : ''}>Cadastrar</button>
                        </div>
                    </div>
                </form>
            </section>
        </section>
      </div>
    );
  }
}

export default Desejos;