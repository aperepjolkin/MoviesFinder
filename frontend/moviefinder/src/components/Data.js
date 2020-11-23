import React, { Component } from 'react';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Row';


export default class Search extends Component {
    
    constructor() {
        super()
        this.state = {
            query: '',
            data: [],
        }
    }
    

    handleInputChange = event => 
        //.log(event.target.value)
        this.setState({
            query: event.target.value
        })
        //this.filterArray();
    

    searchMovie = () => {
        console.log(this.state.query)
         fetch("http://www.omdbapi.com/?apikey=7878efa8&s=batman")
    //     .then(response => response.json())
    //     .then(responseData => {
    //          console.log(responseData)
    //        this.setState({
    //             data:responseData
    //        })
    //    })
    }


    render() {
        return (

            <div>
            <Container>
                <Row>
                <Col>
		        <h2>Movie Search</h2>

                <form>
                    <input type="text" id="filter" placeholder="Search for..." value={this.state.query} onChange={this.handleInputChange}/>
                    <button type="submit" onClick={this.searchMovie} className="btn btn-primary btn-sm">Search</button>
                </form>
                <div>
                    
                </div>
                </Col>
                </Row>
                    
            </Container>
            </div>
            
        )
    }
}