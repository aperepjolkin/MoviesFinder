import React from 'react'
import { Container } from 'react-bootstrap'
import Movie from './Movie';

import { Row } from 'react-bootstrap';
import { Col } from 'react-bootstrap';
import { Form } from 'react-bootstrap';
import { Button } from 'react-bootstrap';


const MovieList = (props) => {
    
   return(
    <Container>
    <Row>
        <Col>
            {
                
                props.movies.map((movie,i) => {
                    return (
                       <Movie key={i} image={movie.poster}/> 
                    )
                })
            }
        </Col>
    </Row>
</Container>

   )
}


export default  MovieList;