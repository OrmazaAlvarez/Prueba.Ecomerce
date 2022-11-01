import React, { Component } from 'react'
import '../assets/css/Sidebar.css'

export class Sidebar extends Component {
    render() {
        return (
            <aside className="Sidebar">
                {this.props.blog &&
                    <div className="Sidebar-item">
                        <h3>You can do this</h3>
                        <a className="btn btn-success" href="/form">Create article</a>
                    </div>
                }
                <div className="Sidebar-item">
                    <h3>Search</h3>
                    <p>Find the item you are looking for</p>
                    <form action="">
                        <input type="text" name="search"/>
                        <input className="btn btn-success" type="submit" name="submit" value="Search"/>
                    </form>
                </div>
            </aside>
        )
    }
}

export default Sidebar
