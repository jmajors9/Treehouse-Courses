import React from 'react'
import PropTypes from 'prop-types'
import GuestInputForm from './GuestInputForm'

const Header = props =>
  <header>
    <h1>RSVP</h1>
    <p>A Treehouse App</p>
    <GuestInputForm
      handleNameInput={props.handleNameInput}
      pendingGuest={props.pendingGuest}
      newGuestSubmitHandler={props.newGuestSubmitHandler}
    />
  </header>;

Header.propTypes = {
  handleNameInput: PropTypes.func.isRequired,
  pendingGuest: PropTypes.string.isRequired,
  newGuestSubmitHandler: PropTypes.func.isRequired
};

export default Header
