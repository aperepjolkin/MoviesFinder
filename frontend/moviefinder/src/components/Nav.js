import React from 'react'
import Nav from "react-bootstrap/Nav"

const Navigation = () => {
    return (
        <Nav
        activeKey="/home"
        onSelect={(selectedKey) => alert(`selected ${selectedKey}`)}
    >
        <Nav.Item>
            <Nav.Link href="/home">Movie Search</Nav.Link>
        </Nav.Item>

        </Nav>
    )
}

export default Navigation;