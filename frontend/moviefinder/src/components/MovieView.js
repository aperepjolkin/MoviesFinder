import React from 'react';
import { Container, Row, Col } from 'react-bootstrap';

const MovieView = (props) => {

    return (
        <Container>
            <Row onClick={props.close} style={{ cursor: "pointer", paddingTop:50}}>
                <span>
                    Back
                </span>
            </Row>
            <Row>
                {props.movieOverview.Poster == null ? <img src={"https://critics.io/img/movies/poster-placeholder.png"} /> :
                 <img src={props.movieOverview.Poster} />}
            </Row>
            <Col>
            <Container>
                <p>{props.movieOverview.Title}</p>
                <p>{props.movieOverview.Actors}</p>
            </Container>
            </Col>
        </Container>
    )
}
export default MovieView;