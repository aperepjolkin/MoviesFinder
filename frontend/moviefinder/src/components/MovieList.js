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
            {
                props.movies.map((movie,i) => {
                    return (
                        <Col>
                             <Movie key={i} movie={movie} viewMovieDetails={props.viewMovieDetails} movieID={movie.Id} /> 
                       </Col>
                    )
                })
            }
        </Row>
    </Container>

   )
}


export default  MovieList;