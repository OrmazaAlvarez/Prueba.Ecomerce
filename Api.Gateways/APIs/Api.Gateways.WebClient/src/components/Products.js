import React, { Component } from 'react'
import '../assets/css/Products.css'
import axios from 'axios'
import Sidebar from './Sidebar'
import Slider from './Slider'
import Product from './Product'


export class Products extends Component {
    state = {
        hasItems: false,
        products: [],
        page:1,
        pages:1,
        total:1
    }

    componentWillMount(){
        this.getProducts(this.state.page);
    }
    getProducts = (pageCurrent) => {
        axios.get(`http://localhost:7883/products?page=${pageCurrent}&take=10`)
             .then(res=>  this.setState({
                    hasItems: res.data.hasItems,
                    products: res.data.items,
                    page: res.data.page,
                    pages: res.data.pages,
                    total: res.data.total
             }));
    }

    netxPage = ()=> this.getProducts(this.state.page + 1)
    prevPage = ()=> this.getProducts(this.state.page - 1)
    
    render() {
        var ListView;
        if (this.state.hasItems){
            ListView = this.state.products.map(p=> {
                return (<Product key={p.productId} name={p.name} description={p.description}/>)
            })
        }else {
            ListView = <h1>There are no products</h1>
        }

    return (
            <React.Fragment>
                <Slider title="Products" />
                <div className="center">
                    <section id="products" className="Content">
                        {ListView}
                        <div className="pagination">
                            <button onClick={this.prevPage} hidden={this.state.page === 1}>{'<<'}</button>
                            Page {this.state.page} of {this.state.pages} - Row Items {this.state.total}
                            <button onClick={this.netxPage.bind(this)} hidden={this.state.page === this.state.pages}>{'>>'}</button>
                        </div>
                    </section>
                    <Sidebar blog={true}/>
                </div>
            </React.Fragment>
        )
    }
}

export default Products