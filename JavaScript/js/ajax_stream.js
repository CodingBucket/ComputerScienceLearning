function ajax_stream(){
            if (!window.XMLHttpRequest){
                alert("Your browser does not support the native XMLHttpRequest object.");
                return;
            }
            try{
                var xhr = new XMLHttpRequest();  
                xhr.previous_text = '';
                                 
                xhr.onerror = function() { alert("[XHR] Fatal Error."); };
                xhr.onreadystatechange = function() {
                    try{
                        if (xhr.readyState == 4){
                            alert('[XHR] Done')
                        } 
                        else if (xhr.readyState > 2){
                            var new_response = xhr.responseText.substring(xhr.previous_text.length);
                            var result = JSON.parse( new_response );
                            
                            document.getElementById("divProgress").innerHTML += result.message + '<br />';
                            document.getElementById('progressor').style.width = result.progress + "%";
                            
                            xhr.previous_text = xhr.responseText;
                        }  
                    }
                    catch (e){
                        alert("[XHR STATECHANGE] Exception: " + e);
                    }                     
                };
                xhr.open("GET", "ajax_stream.php", true);
                xhr.send();      
            }
            catch (e){
                alert("[XHR REQUEST] Exception: " + e);
            }
        }
