import React, { Component } from 'react'
import '../assets/css/Slider.css'

export class Slider extends Component {
    render() {
        return (
            <div id="Slider" className="Slider">
                <h2>{this.props.title}</h2>
            </div>
        )
    }
}

export default Slider
