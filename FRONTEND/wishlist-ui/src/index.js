import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom';

// CSS:
import './assets/css/index.css';

// PÁGINAS:
import App from './pages/home/App';
import NotFound from './pages/notFound/notFound';
import Desejos from './pages/desejos/desejos';

import reportWebVitals from './reportWebVitals';

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={App} /> {/* Home */}
        <Route path="/desejos" component={Desejos} /> {/* Desejos */}
        <Route exact path="/notfound" component={NotFound} /> {/* Not Found */}
        <Redirect to="/notfound" /> {/* Redireciona para NotFound caso não encontre nenhuma rota */}
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(routing, document.getElementById('root'));

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
