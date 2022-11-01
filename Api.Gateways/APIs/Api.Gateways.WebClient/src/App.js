import './assets/css/App.css';
import { BrowserRouter, Route, Switch } from 'react-router-dom'
import Header from './components/Header';
import Home from "./components/Home";
import Products from './components/Products';
import Footer from './components/Footer';
import Error from './components/Error';



function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Header />
        <div className="clearfix"></div>
        <Switch>
          <Route exact path="/home" component={Home} />
          <Route exact path="/products" component={Products} />
          <Route component={Error} />
        </Switch>
        <div className="clearfix"></div>
        <Footer/>
      </div>
    </BrowserRouter>
  );
}

export default App;
