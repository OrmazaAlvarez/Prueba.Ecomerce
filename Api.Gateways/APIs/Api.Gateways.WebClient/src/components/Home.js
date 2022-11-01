import React, { Component } from 'react'
import '../assets/css/Home.css'
import Slider from './Slider';
import Sidebar from './Sidebar';

export class Home extends Component {
    render() {
        return (
            <React.Fragment>
                <Slider title="Welcome to my test application with React" />
                <div className="center">
                    <section className="Content">
                        <h1>Latest Landscapes</h1>
                        <article className="article-item">
                            <div className="image-wrap">
                                <img src="https://astelus.com/wp-content/viajes/Lago-Moraine-Parque-Nacional-Banff-Alberta-Canada-1440x810.jpg" alt="Landscape"/>
                            </div>
                            <div className="info-image">
                                <h2>Test Landscapes</h2>
                                <span className="date">5 minutes ago.</span>
                                <a href="/mas">Read more</a>
                            </div>
                        </article>
                    </section>
                    <Sidebar/>
                </div>
            </React.Fragment>
        )
    }
}

export default Home