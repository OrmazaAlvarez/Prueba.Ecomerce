import React, { Component } from "react";
import { NavLink } from "react-router-dom";
import "../assets/css/Header.css";
import logo from "../assets/images/logo.svg";

export class Header extends Component {
  render() {
    return (
      <header className="Header">
        <div className="center">
            <div className="Header-logo">
                <img src={logo} alt="logo" />
                <span id="Header-brand">
                    Test <strong>React</strong>
                </span>
            </div>
            <nav className="Header-menu">
                <ul>
                    <li>
                        <NavLink to="/home" activeClassName="active">Home</NavLink>
                    </li>
                    <li>
                        <NavLink to="/products" activeClassName="active">Products</NavLink>
                    </li>
                </ul>
            </nav>
        </div>
      </header>
    );
  }
}

export default Header;
