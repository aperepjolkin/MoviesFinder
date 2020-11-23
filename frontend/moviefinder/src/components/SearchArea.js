import React from 'react';
import { Container } from 'react-bootstrap';
import { Row } from 'react-bootstrap';
import { Col } from 'react-bootstrap';
import { Form } from 'react-bootstrap';
import { Button } from 'react-bootstrap';

const SearchArea = (props) => {
    return (
        <Container>
            <Row>
                <Col>
                    <Form>
                         <Form.Control type="text" placeholder="Search movie" onChange={props.handleChange}/>
                         <Button variant="primary" type="submit" onClick={props.handleSubmit}> Search</Button>
                    </Form>
                 </Col>
            </Row>
        </Container>
    )
}
export default SearchArea;