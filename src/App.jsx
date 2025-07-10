import './App.css'
import { Canvas } from '@react-three/fiber'
import { OrbitControls } from '@react-three/drei'

function App() {
  return (
    <div className="main-container">
      
      <div className="canvas-container">
        <Canvas camera={{ position: [0, 0, 5], fov: 50 }}>
          <ambientLight />
          <directionalLight position={[2, 2, 2]} />

          <mesh position={[0, 0, 0]}>
            <boxGeometry args={[2, 2, 2]} />
            <meshStandardMaterial color={'orange'} />
          </mesh>

          <OrbitControls />
        </Canvas>
      </div>
    </div>
  )
}

export default App
