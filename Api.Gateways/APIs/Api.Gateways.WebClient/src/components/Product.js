import React, { Component } from 'react'

export class Product extends Component {
    render() {
        return (
            <div >
                <p><strong>{this.props.name}</strong> {this.props.description}</p>
            </div>
        )
    }
}

export default Product
