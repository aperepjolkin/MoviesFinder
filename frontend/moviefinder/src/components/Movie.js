import React from 'react';
import { Col } from 'react-bootstrap';
import { Card } from 'react-bootstrap';
import { Button } from 'react-bootstrap';
const Movie = (props) => {

    var movie = JSON.stringify(props.movie)

    return (<Col>
            <Card style={{ width: '18rem' }}>
            <Card.Img variant="top" src={props.movie.Poster} />
            <Card.Body>
                <Card.Title>{props.movie.Title}</Card.Title>
                <Card.Text>
                    {props.movie.Actors}
                </Card.Text>
                <Button variant="primary">Details</Button>
            </Card.Body>
            </Card>
    </Col>)
        
    
}

export default Movie;