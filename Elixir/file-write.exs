defmodule WriteFile do
	def write(filename, value) do
		{:ok, file} = File.open filename, [:write]
		IO.binwrite file, value
		File.close file
	end
end

WriteFile.write("./file.html", "<p>Hellow Elixir</p>")
