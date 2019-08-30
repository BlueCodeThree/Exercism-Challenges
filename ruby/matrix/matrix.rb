class Matrix
    def initialize(matrix_string)
        @matrix = matrix_string.split(/\n+/).map{|x| x.split(" ")}.map{&:to_i}
    end

    def rows

    end
end

p Matrix.new("1 2\n10 20")