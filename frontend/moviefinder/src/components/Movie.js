import React from 'react';
import { Col } from 'react-bootstrap';
import { Card } from 'react-bootstrap';
import { Button } from 'react-bootstrap';
const Movie = (props) => {
    return (<Col>
            <Card style={{ width: '18rem' }}>
            <Card.Img variant="top" src={props.poster} />
            <Card.Body>
                <Card.Title>{props.title}</Card.Title>
                <Card.Text>
                    Some quick example text to build on the card title and make up the bulk of
                    the card's content.
                </Card.Text>
                <Button variant="primary">Details</Button>
            </Card.Body>
            </Card>
    </Col>)
        
    
}

export default Movie;