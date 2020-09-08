import React from 'react';

import Message from '../Message/Message';

const ChatWindow = (props) => {
  const chat = props.chat.map((m, index) => 
    <Message 
      key={index}
      user={m.user}
      message={m.message}
    />
  );

  return (
    <div>
      {chat}
    </div>
  )
};

export default ChatWindow;
